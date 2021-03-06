﻿namespace mission_board
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.missionary_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.recent_letter_listBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.back_to_map_button = new System.Windows.Forms.Button();
            this.missionary_letter_list_label = new System.Windows.Forms.Label();
            this.mission_field_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.missionary_letter_listBox = new System.Windows.Forms.ListBox();
            this.infobox_panel = new System.Windows.Forms.Panel();
            this.field_label = new System.Windows.Forms.Label();
            this.view_profile_button = new System.Windows.Forms.Button();
            this.inforbox_name_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.mapUserControl1 = new mission_board.MapUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).BeginInit();
            this.infobox_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // missionary_listBox
            // 
            this.missionary_listBox.BackColor = System.Drawing.Color.White;
            this.missionary_listBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionary_listBox.FormattingEnabled = true;
            this.missionary_listBox.ItemHeight = 23;
            this.missionary_listBox.Location = new System.Drawing.Point(51, 250);
            this.missionary_listBox.Margin = new System.Windows.Forms.Padding(4);
            this.missionary_listBox.Name = "missionary_listBox";
            this.missionary_listBox.Size = new System.Drawing.Size(216, 372);
            this.missionary_listBox.TabIndex = 1;
            this.missionary_listBox.SelectedIndexChanged += new System.EventHandler(this.missionary_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Missionaries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 684);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recent Letters";
            // 
            // recent_letter_listBox
            // 
            this.recent_letter_listBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent_letter_listBox.FormattingEnabled = true;
            this.recent_letter_listBox.ItemHeight = 23;
            this.recent_letter_listBox.Location = new System.Drawing.Point(53, 722);
            this.recent_letter_listBox.Margin = new System.Windows.Forms.Padding(4);
            this.recent_letter_listBox.Name = "recent_letter_listBox";
            this.recent_letter_listBox.Size = new System.Drawing.Size(213, 280);
            this.recent_letter_listBox.TabIndex = 12;
            this.recent_letter_listBox.SelectedIndexChanged += new System.EventHandler(this.recent_letter_listBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.back_to_map_button);
            this.panel1.Controls.Add(this.missionary_letter_list_label);
            this.panel1.Controls.Add(this.mission_field_label);
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.profile_pictureBox);
            this.panel1.Controls.Add(this.missionary_letter_listBox);
            this.panel1.Location = new System.Drawing.Point(297, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2279, 1366);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1091, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 1093);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 627);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Go To Map Location";
            // 
            // back_to_map_button
            // 
            this.back_to_map_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_to_map_button.BackgroundImage")));
            this.back_to_map_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_to_map_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_to_map_button.Location = new System.Drawing.Point(298, 673);
            this.back_to_map_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_to_map_button.Name = "back_to_map_button";
            this.back_to_map_button.Size = new System.Drawing.Size(193, 122);
            this.back_to_map_button.TabIndex = 13;
            this.back_to_map_button.UseVisualStyleBackColor = true;
            this.back_to_map_button.Click += new System.EventHandler(this.back_to_map_button_Click);
            // 
            // missionary_letter_list_label
            // 
            this.missionary_letter_list_label.AutoSize = true;
            this.missionary_letter_list_label.BackColor = System.Drawing.Color.Transparent;
            this.missionary_letter_list_label.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionary_letter_list_label.Location = new System.Drawing.Point(847, 155);
            this.missionary_letter_list_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.missionary_letter_list_label.Name = "missionary_letter_list_label";
            this.missionary_letter_list_label.Size = new System.Drawing.Size(113, 31);
            this.missionary_letter_list_label.TabIndex = 5;
            this.missionary_letter_list_label.Text = "Letters";
            // 
            // mission_field_label
            // 
            this.mission_field_label.AutoSize = true;
            this.mission_field_label.BackColor = System.Drawing.Color.Transparent;
            this.mission_field_label.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mission_field_label.Location = new System.Drawing.Point(40, 79);
            this.mission_field_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mission_field_label.Name = "mission_field_label";
            this.mission_field_label.Size = new System.Drawing.Size(221, 39);
            this.mission_field_label.TabIndex = 4;
            this.mission_field_label.Text = "Mission Field";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Black;
            this.name_label.Location = new System.Drawing.Point(39, 23);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(383, 46);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Missionary Name";
            // 
            // profile_pictureBox
            // 
            this.profile_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profile_pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.profile_pictureBox.Location = new System.Drawing.Point(47, 133);
            this.profile_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profile_pictureBox.Name = "profile_pictureBox";
            this.profile_pictureBox.Size = new System.Drawing.Size(733, 469);
            this.profile_pictureBox.TabIndex = 2;
            this.profile_pictureBox.TabStop = false;
            // 
            // missionary_letter_listBox
            // 
            this.missionary_letter_listBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionary_letter_listBox.FormattingEnabled = true;
            this.missionary_letter_listBox.ItemHeight = 18;
            this.missionary_letter_listBox.Location = new System.Drawing.Point(853, 190);
            this.missionary_letter_listBox.Margin = new System.Windows.Forms.Padding(4);
            this.missionary_letter_listBox.Name = "missionary_letter_listBox";
            this.missionary_letter_listBox.Size = new System.Drawing.Size(207, 238);
            this.missionary_letter_listBox.TabIndex = 0;
            this.missionary_letter_listBox.SelectedIndexChanged += new System.EventHandler(this.missionary_letter_listBox_SelectedIndexChanged);
            // 
            // infobox_panel
            // 
            this.infobox_panel.AutoSize = true;
            this.infobox_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infobox_panel.BackColor = System.Drawing.Color.LightGray;
            this.infobox_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infobox_panel.Controls.Add(this.field_label);
            this.infobox_panel.Controls.Add(this.view_profile_button);
            this.infobox_panel.Controls.Add(this.inforbox_name_label);
            this.infobox_panel.Location = new System.Drawing.Point(16, 1046);
            this.infobox_panel.Margin = new System.Windows.Forms.Padding(4);
            this.infobox_panel.MaximumSize = new System.Drawing.Size(0, 150);
            this.infobox_panel.Name = "infobox_panel";
            this.infobox_panel.Size = new System.Drawing.Size(288, 188);
            this.infobox_panel.TabIndex = 6;
            // 
            // field_label
            // 
            this.field_label.AutoSize = true;
            this.field_label.BackColor = System.Drawing.Color.Transparent;
            this.field_label.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_label.Location = new System.Drawing.Point(27, 38);
            this.field_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_label.MinimumSize = new System.Drawing.Size(67, 0);
            this.field_label.Name = "field_label";
            this.field_label.Size = new System.Drawing.Size(84, 35);
            this.field_label.TabIndex = 3;
            this.field_label.Text = "Field";
            this.field_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // view_profile_button
            // 
            this.view_profile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.view_profile_button.AutoSize = true;
            this.view_profile_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.view_profile_button.BackColor = System.Drawing.SystemColors.Menu;
            this.view_profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_profile_button.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_profile_button.Location = new System.Drawing.Point(60, 63);
            this.view_profile_button.Margin = new System.Windows.Forms.Padding(4);
            this.view_profile_button.Name = "view_profile_button";
            this.view_profile_button.Size = new System.Drawing.Size(112, 32);
            this.view_profile_button.TabIndex = 2;
            this.view_profile_button.Text = "View Profile";
            this.view_profile_button.UseVisualStyleBackColor = false;
            this.view_profile_button.Click += new System.EventHandler(this.view_profile_button_Click);
            // 
            // inforbox_name_label
            // 
            this.inforbox_name_label.AutoSize = true;
            this.inforbox_name_label.BackColor = System.Drawing.Color.Transparent;
            this.inforbox_name_label.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforbox_name_label.Location = new System.Drawing.Point(27, 5);
            this.inforbox_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inforbox_name_label.MinimumSize = new System.Drawing.Size(67, 0);
            this.inforbox_name_label.Name = "inforbox_name_label";
            this.inforbox_name_label.Size = new System.Drawing.Size(199, 33);
            this.inforbox_name_label.TabIndex = 1;
            this.inforbox_name_label.Text = "Missionary Name";
            this.inforbox_name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // close_button
            // 
            this.close_button.BackgroundImage = global::mission_board.Properties.Resources.BBC_Logo;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(67, 1113);
            this.close_button.Margin = new System.Windows.Forms.Padding(4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(197, 135);
            this.close_button.TabIndex = 7;
            this.close_button.UseMnemonic = false;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_button_MouseClick);
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::mission_board.Properties.Resources.globe_icon;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Location = new System.Drawing.Point(67, 5);
            this.home_button.Margin = new System.Windows.Forms.Padding(4);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(188, 175);
            this.home_button.TabIndex = 6;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(297, -11);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(2264, 1366);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.mapUserControl1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(7411, 3350);
            this.ControlBox = false;
            this.Controls.Add(this.recent_letter_listBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.infobox_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.missionary_listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1835, 1054);
            this.Name = "Form1";
            this.Text = "Mission Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).EndInit();
            this.infobox_panel.ResumeLayout(false);
            this.infobox_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MapUserControl mapUserControl1;
        private System.Windows.Forms.ListBox missionary_listBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox missionary_letter_listBox;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox profile_pictureBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label mission_field_label;
        private System.Windows.Forms.Label missionary_letter_list_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel infobox_panel;
        private System.Windows.Forms.Label inforbox_name_label;
        private System.Windows.Forms.Button view_profile_button;
        private System.Windows.Forms.Label field_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_to_map_button;
        private System.Windows.Forms.ListBox recent_letter_listBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

