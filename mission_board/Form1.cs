﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Maps.MapControl.WPF;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Drawing.Imaging;
using System.Configuration;

namespace mission_board
{
    public partial class Form1 : Form
    {
        private readonly string _missionaryDataFileName;
        private readonly string _errorLogFileName;
        private readonly string _pdfLetterDirectory;
        private readonly string _jpgLetterDirectory;
        private readonly string _bingApiKey;
        private readonly string _emailUsername;
        private readonly string _emailPassword;
        private List<FileInfo> missionaryLetters;
        private string selectedLetter;
        private string selectedMissionary;
        private int maxListLetters = 20;
        private int moveTracker = 0;
        private string selectedPushpinName = string.Empty;
        private float letterDpi = 500f;
        private bool closeForm = false;
        private SortedList<string, Missionary> missionaryList = new SortedList<string, Missionary>();

        public Form1()
        {
            InitializeComponent();

            _missionaryDataFileName = Properties.Settings.Default.DataFileLocation;
            _errorLogFileName = Properties.Settings.Default.ErrorLogFileLocation;
            _pdfLetterDirectory = Properties.Settings.Default.PdfLetterDirectory;
            _jpgLetterDirectory = Properties.Settings.Default.JpgLetterDirectory;
            _bingApiKey = ConfigurationManager.AppSettings.Get("BingApiKey");
            _emailUsername = ConfigurationManager.AppSettings.Get("EmailUsername");
            _emailPassword = ConfigurationManager.AppSettings.Get("EmailPassword");

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            mapUserControl1.Map.CredentialsProvider = new ApplicationIdCredentialsProvider(_bingApiKey);
            mapUserControl1.Map.AnimationLevel = AnimationLevel.None;
            mapUserControl1.Map.SupportedManipulations = System.Windows.Input.Manipulations.Manipulations2D.Scale | System.Windows.Input.Manipulations.Manipulations2D.Translate;
            mapUserControl1.Map.ZoomLevel = 3;
            mapUserControl1.Map.TargetViewChanged += Map_TargetViewChanged;
            mapUserControl1.Map.ViewChangeOnFrame += Map_ViewChangeOnFrame;
            ShowMap(true);

            keyboard1.Location = new Point(500, 700);

            if (!LoadMissionaryData(_missionaryDataFileName))
            {
                closeForm = true;
            }
            LoadMapMarkers();
            LoadMissionaryLetters();
            PopulateRecentMissionaryLettersList();
            LoadMissionaryList();
        }

        public List<string> GetLetterPages(string pdf)
        {
            string pdfFileLocation;
            List<string> letterPages = new List<string>();
            try
            {
                using (var document = PdfiumViewer.PdfDocument.Load(pdf))
                {
                    for (int index = 0; index < document.PageCount; index++)
                    {
                        pdfFileLocation = _jpgLetterDirectory + pdf.Substring(pdf.LastIndexOf("\\") + 1) + index.ToString() + ".jpg";
                        if (File.Exists(pdfFileLocation))
                            letterPages.Add(pdfFileLocation);
                        else
                        {
                            // Coverts pdf to jpeg. I thank the Lord for this render method. It's fast and blessed
                            Image image = document.Render(index, letterDpi, letterDpi, PdfiumViewer.PdfRenderFlags.LcdText);
                            image.Save(pdfFileLocation, ImageFormat.Jpeg);
                            letterPages.Add(pdfFileLocation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                WriteErrorToLog(ex.Message);
            }
            return letterPages;
        }

        private void ShowMap(bool showMap)
        {
            if (showMap)
            {
                panel1.Visible = false;
                infobox_panel.Visible = false;
                elementHost1.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                infobox_panel.Visible = false;
                elementHost1.Visible = false;
            }
        }

        // This method makes it so the pop up on the missionary marker stay open if it senses a little movement (most likely unintential movement)
        private void Map_ViewChangeOnFrame(object sender, MapEventArgs e)
        {
            if (infobox_panel.Visible)
            {
                moveTracker += 1;
                if (moveTracker > 3)
                {
                    infobox_panel.Visible = false;
                    moveTracker = 0;
                }
            }
        }

        private void Map_TargetViewChanged(object sender, MapEventArgs e)
        {
            if (mapUserControl1.Map.ZoomLevel > 15)
                mapUserControl1.Map.ZoomLevel = 15;
            if (mapUserControl1.Map.ZoomLevel < 3)
                mapUserControl1.Map.ZoomLevel = 3;
        }

        private void LoadMapMarkers()
        {
            foreach (Missionary miss in missionaryList.Values)
            {
                Pushpin pushpin = new Pushpin();
                pushpin.Location = new Location(miss.Latitude, miss.Longitude);
                pushpin.Name = miss.DisplayName.Replace(" ", "_");
                pushpin.MouseDown += Pushpin_MouseDown;
                mapUserControl1.Map.Children.Add(pushpin);
            }
        }

        private void Pushpin_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Pushpin pin = (Pushpin)sender;
            string missionaryName = pin.Name.Replace("_", " ");

            Point coordinates = Cursor.Position;

            infobox_panel.Visible = false;
            infobox_panel.Location = new Point(coordinates.X, coordinates.Y);
            infobox_panel.Visible = true;
            infobox_panel.BringToFront();
            moveTracker = 0;
            inforbox_name_label.Text = missionaryName;
            field_label.Text = missionaryList[missionaryName].MissionField;
            selectedPushpinName = pin.Name;
        }

        private bool LoadMissionaryData(string csvFile)
        {
            /// TODO:
            /// REFACTOR THIS METHOD
            int validColumnCount = 9;

            if (!File.Exists(csvFile))
            {
                WriteErrorToLog("FATAL ERROR: " + csvFile + " is either missing or corrupted." + Environment.NewLine);
                return false;
            }
            try
            {
                string[] missionaryDataRows = File.ReadAllLines(csvFile);
                string[] splitLine;
                Missionary missionary;
                foreach (string line in missionaryDataRows)
                {
                    if (!line.Contains("Display_Name")) // skip first line, I don't like doing it this way, shameful
                    {
                        // [0]          [1]             [2]         [3]         [4]         [5]         [6]     [7]
                        // Display_Name	Mission_Field	First_Name	Last_Name	Latitude	Longitude	Email	Profile_Picture

                        splitLine = line.Split(",".ToCharArray());
                        missionary = new Missionary();

                        if (splitLine.Length == validColumnCount) // so we don't go out of bounds on the array
                        {
                            missionary.DisplayName = splitLine[0].Trim();
                            missionary.MissionField = splitLine[1].Trim();
                            missionary.FirstName = splitLine[2].Trim();
                            missionary.LastName = splitLine[3].Trim();
                            missionary.Email = splitLine[6].Trim();
                            missionary.ProfilePicture = splitLine[7].Trim();
                            missionary.LetterAlias = splitLine[8].Trim();
                            try
                            {
                                missionary.Latitude = Convert.ToDouble(splitLine[4]);
                            }
                            catch (OverflowException)
                            {
                                WriteErrorToLog(splitLine[4] + " is outside the range of the Int64 type for " + missionary.DisplayName + Environment.NewLine);
                            }
                            catch (FormatException)
                            {
                                WriteErrorToLog(splitLine[4] + "  is not in a recognizable latitude format for " + missionary.DisplayName + Environment.NewLine);
                            }
                            try
                            {
                                missionary.Longitude = Convert.ToDouble(splitLine[5]);
                            }
                            catch (OverflowException)
                            {
                                WriteErrorToLog(splitLine[5] + " is outside the range of the Int64 type for " + missionary.DisplayName + Environment.NewLine);
                            }
                            catch (FormatException)
                            {
                                WriteErrorToLog(splitLine[5] + "  is not in a recognizable longitude format for " + missionary.DisplayName + Environment.NewLine);
                            }

                            missionaryList.Add(splitLine[0], missionary);
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure that " + csvFile + " is closed and not in use.");
                WriteErrorToLog(csvFile + "  is open or in use."+ Environment.NewLine);
                return false;
                
            }
            return true;
        }

        private void WriteErrorToLog(string error)
        {
            String timeStamp = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + ":";
            File.AppendAllText(_errorLogFileName, timeStamp + " " + error);
        }

        private void LoadMissionaryLetters()
        {
            string missionaryName = "";

            missionaryLetters = new DirectoryInfo(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Missionary_Letters").GetFiles()
                                                  .OrderByDescending(f => f.LastAccessTime)
                                                  .ToList();

            ClearMissionaryLetters();
            foreach (FileInfo letter in missionaryLetters)
            {
                missionaryName = LookupLetterOwnership(letter.Name);

                if (missionaryName != null)
                {
                    if (!missionaryList[missionaryName].Letters.Contains(letter))
                        missionaryList[missionaryName].Letters.Add(letter);
                }
                else
                {
                    WriteErrorToLog("Letter does not match any missionary.");
                }
            }
        }

        private void PopulateRecentMissionaryLettersList()
        {
            string[] files = System.IO.Directory.GetFiles(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Missionary_Letters");

            var sortedFiles = new DirectoryInfo(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Missionary_Letters").GetFiles()
                                                  .OrderByDescending(f => f.LastAccessTime)
                                                  .ToList();
            string missionaryName = string.Empty;
            int month = 0, day = 0;
            string monthString = string.Empty, dayString = string.Empty;
            recent_letter_listBox.Items.Clear();

            if (sortedFiles.Count < maxListLetters)
                maxListLetters = sortedFiles.Count;
            List<string> miss = new List<string>();

            foreach (FileInfo letter in sortedFiles)
            {
                missionaryName = LookupLetterOwnership(letter.Name);

                if (missionaryName != null)
                {
                    if (!miss.Contains(missionaryName))
                    {
                        if (miss.Count < maxListLetters)
                        {
                            month = letter.LastAccessTime.Month;
                            day = letter.LastAccessTime.Day;
                            if (month < 10)
                                monthString = "0" + month.ToString();
                            else
                                monthString = month.ToString();
                            if (day < 10)
                                dayString = "0" + day.ToString();
                            else
                                dayString = day.ToString();
                            recent_letter_listBox.Items.Add((monthString + "/" + dayString + " - ").PadRight(8) + missionaryName);
                            miss.Add(missionaryName);
                        }
                        else
                            break;
                    }
                }
            }
        }

        private void PopulateIndividualMissionaryLetterList(string name)
        {
            missionary_letter_listBox.Items.Clear();
            foreach (FileInfo letter in missionaryList[name].Letters)
            {
                missionary_letter_listBox.Items.Add(name + " - " + letter.LastAccessTime.Month + "/" + letter.LastAccessTime.Day);
            }
        }

        // Critical method for associating a letter with the missionary
        private string LookupLetterOwnership(string letterName)
        {
            string missionaryName = null;
            letterName = letterName.ToLower();

            foreach (Missionary missionary in missionaryList.Values)
            {
                // This alias has to be in the letter name!!! Make sure it's unique!!
                if (letterName.Contains(missionary.LetterAlias.ToLower()))
                { 
                    missionaryName = missionary.DisplayName;
                    break;
                }
            }
            return missionaryName;
        }

        private void LoadMissionaryList()
        {
            /// TODO:
            /// I BELIEVE THIS CAN BE DONE EASIER WITH LINQ
            SortedList<string, string> missionaryList2 = new SortedList<string, string>();

            // Sort alphabetically
            foreach (Missionary missionary in missionaryList.Values)
            {
                missionaryList2.Add(missionary.LastName + "-" + missionary.FirstName, missionary.LastName + ", " + missionary.FirstName);
            }

            foreach (string missionary in missionaryList2.Values)
            {
                missionary_listBox.Items.Add(missionary);
            }
        }

        private void ClearMissionaryLetters()
        {
            foreach (Missionary missionary in missionaryList.Values)
                missionary.Letters.Clear();
        }

        private void missionary_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (missionary_listBox.SelectedIndex >= 0)
            {
                ShowMap(true);
                infobox_panel.Visible = false;
                string name = missionary_listBox.Items[missionary_listBox.SelectedIndex].ToString();
                string missionary_name = LookupMissionaryListbox(name);
                Location mapCenter = new Location(missionaryList[missionary_name].Latitude,
                                                   missionaryList[missionary_name].Longitude);
                mapUserControl1.Map.SetView(mapCenter, 5);

                int element_center_x = elementHost1.Width / 2;
                int element_center_y = elementHost1.Height / 2;
                infobox_panel.Location = new Point(element_center_x + elementHost1.Left, element_center_y + elementHost1.Top);//((int)(calculate_infobox_positionX(pin) - elementHost1.Location.X), (int)(calculate_infobox_positionY(pin) + elementHost1.Location.Y));
                infobox_panel.Visible = true;
                infobox_panel.BringToFront();
                moveTracker = 0;
                inforbox_name_label.Text = missionary_name;
                field_label.Text = missionaryList[missionary_name].MissionField;
                selectedPushpinName = name;
            }
        }

        private string LookupMissionaryListbox(string name)
        {
            string missionaryName = null;
            name = name.ToLower();

            foreach (Missionary missionary in missionaryList.Values)
            {
                if (name.Contains(missionary.LetterAlias.ToLower()) ||
                    (name.Contains(missionary.FirstName.ToLower()) && name.Contains(missionary.LastName.ToLower())))
                {
                    missionaryName = missionary.DisplayName;
                    break;
                }
            }
            return missionaryName;
        }

        private void UpdateProfile(string name)
        {
            ShowMap(false);
            keyboard1.Visible = false;
            string missionaryName = LookupMissionaryListbox(name);
            selectedMissionary = missionaryName;

            if (File.Exists("Profile_Pictures\\" + missionaryList[missionaryName].ProfilePicture))
            {
                profile_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                profile_pictureBox.Image = System.Drawing.Image.FromFile("Profile_Pictures\\" + missionaryList[missionaryName].ProfilePicture);
            }
            else
                profile_pictureBox.Image = null;

            name_label.Text = missionaryName;
            mission_field_label.Text = missionaryList[missionaryName].MissionField;

            if (missionaryList[missionaryName].Letters.Count > 0)
            {
                selectedLetter = missionaryList[missionaryName].Letters[0].FullName;
                pictureBox1.Image = Image.FromFile(GetLetterPages(missionaryList[missionaryName].Letters[0].FullName)[0]);

            }
            else
            {
                pictureBox1.Image = null;
            }
            PopulateIndividualMissionaryLetterList(missionaryName);

        }

        private void missionary_letter_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (missionary_letter_listBox.SelectedIndex >= 0)
            {
                string missionary_name = missionary_letter_listBox.Items[missionary_letter_listBox.SelectedIndex].ToString();

                missionary_name = LookupMissionaryListbox(missionary_name);

                if (!missionaryList.ContainsKey(missionary_name))
                    return;

                if (missionary_name != null)
                {
                    selectedLetter = missionaryList[missionary_name].Letters[missionary_letter_listBox.SelectedIndex].FullName;
                    pictureBox1.Image = Image.FromFile(GetLetterPages(selectedLetter)[0]);
                }
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            ShowMap(true);
        }

        private void close_button_Click(object sender, EventArgs e)
        {

        }

        private void down_button_Click(object sender, EventArgs e)
        {

            missionary_listBox.TopIndex += 1;
        }

        private void scroll_up_button_Click(object sender, EventArgs e)
        {
            missionary_listBox.TopIndex -= 1;
        }

        private void recent_letter_listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_profile_button_Click(object sender, EventArgs e)
        {
            ShowMap(false);
            UpdateProfile(selectedPushpinName);
        }

        private void send_mail_Click(object sender, EventArgs e)
        {
            keyboard1.Text = "";
            keyboard1.Visible = true;
            keyboard1.BringToFront();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SendEmail(keyboard1.Text, "parkviewmissions@gmail.com", "smtp.gmail.com", "Mission Board Letter", "", selectedLetter);
        }

        public void SendEmail(string recipient, string sender, string smtp_server, string subject, string message, string attachment)
        {

            /// TODO:
            /// REMOVE HARD CODED CREDENTIALS AND MOVE TO APP.CONFIG
            try
            {
                MailMessage mailMsg = new MailMessage();

                mailMsg.To.Add(new MailAddress(recipient));
                mailMsg.From = new MailAddress(sender);
                mailMsg.Subject = subject;
                mailMsg.IsBodyHtml = true;
                mailMsg.Body = message;
                mailMsg.Attachments.Add(new Attachment(attachment));
                mailMsg.Priority = MailPriority.Normal;

                SmtpClient smtpClient = new SmtpClient(smtp_server);
                smtpClient.Port = 587; // for gmail

                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_emailUsername, _emailPassword);
                smtpClient.Send(mailMsg);
            }
            catch (Exception e)
            {
                File.AppendAllText("error.log", DateTime.Now.ToShortDateString() + " "
                                            + DateTime.Now.ToShortTimeString() + " "
                                            + e.Message + Environment.NewLine);
            }

        }

        private void keyboard1_SendButtonClick(object sender, EventArgs e)
        {
            /// TODO:
            /// VERY BAD - FIX THIS
            if (keyboard1.Text == "stark9355")
                Form1.ActiveForm.Dispose();
            keyboard1.Visible = false;

            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }

        private void back_to_map_button_Click(object sender, EventArgs e)
        {
            ShowMap(true);
            infobox_panel.Visible = false;
            string missionary_name = selectedMissionary;
            Location center_map = new Location(missionaryList[missionary_name].Latitude,
                                               missionaryList[missionary_name].Longitude);
            mapUserControl1.Map.SetView(center_map, 5);

            int element_center_x = elementHost1.Width / 2;
            int element_center_y = elementHost1.Height / 2;
            infobox_panel.Location = new Point(element_center_x + elementHost1.Left, element_center_y + elementHost1.Top);
            infobox_panel.Visible = true;
            infobox_panel.BringToFront();
            moveTracker = 0;
            inforbox_name_label.Text = missionary_name;
            field_label.Text = missionaryList[missionary_name].MissionField;
            selectedPushpinName = missionary_name;
        }

        private void keyboard1_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            keyboard1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void recent_letter_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recent_letter_listBox.SelectedItems.Count > 0)
            {
                string missionary_letter = recent_letter_listBox.Items[recent_letter_listBox.SelectedIndex].ToString();
                missionary_letter = missionary_letter.Substring(8).Trim();

                if (missionaryList.ContainsKey(missionary_letter))
                    missionary_letter = missionaryList[missionary_letter].LetterAlias;
                else
                    return;

                if (missionary_letter != null)
                {
                    UpdateProfile(missionary_letter);
                }
            }
        }

        private void close_button_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (closeForm)
                Form1.ActiveForm.Dispose();
        }
    }
}
