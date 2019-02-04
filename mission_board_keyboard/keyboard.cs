using mission_board_keyboard.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace mission_board_keyboard
{
	public class keyboard : UserControl
	{
		private bool shift_key = false;

		private bool caps_lock_key = false;

		private RegexUtilities util = new RegexUtilities();

		private IContainer components = null;

		private Button button1;

		private TextBox textBox1;

		private Button button2;

		private Button button3;

		private Button button4;

		private Button button5;

		private Button button6;

		private Button button7;

		private Button button8;

		private Button button9;

		private Button button10;

		private Button button11;

		private Button button12;

		private Button button13;

		private Button button14;

		private Button button15;

		private Button button16;

		private Button button17;

		private Button button18;

		private Button button19;

		private Button button20;

		private Button button21;

		private Button button25;

		private Button button26;

		private Button button27;

		private Button button28;

		private Button button29;

		private Button button30;

		private Button shift_button;

		private Button caps_lock_button;

		private Button button22;

		private Button button23;

		private Button button24;

		private Button button31;

		private Button button32;

		private Button button33;

		private Button button34;

		private Button button35;

		private Button button36;

		private Button button37;

		private Button button38;

		private Button button39;

		private Button button40;

		private Button button41;

		private Button button42;

		private Button button43;

		private Button button44;

		private Button button45;

		private Button button46;

		private Button button47;

		private Button button48;

		private Button button49;

		private Button button50;

		private Button button51;

		private Button button52;

		private Button button53;

		private Button button54;

		private Label label1;

		[Description("Test text displayed in the textbox")]
		[Category("Data")]
		public new string Text
		{
			get
			{
				return textBox1.Text;
			}
			set
			{
				textBox1.Text = value;
			}
		}

		public event EventHandler SendButtonClick;

		public keyboard()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.SendButtonClick != null)
			{
				this.SendButtonClick(this, e);
			}
		}

		private void type_key(string lower, string upper)
		{
			textBox1.Focus();
			if (!shift_key && !caps_lock_key)
			{
				SendKeys.Send(lower);
			}
			else if (caps_lock_key && !upper.Contains("{"))
			{
				if (!shift_key)
				{
					SendKeys.Send(upper);
					return;
				}
				SendKeys.Send(lower);
				shift_key = false;
			}
			else if (shift_key)
			{
				SendKeys.Send(upper);
				shift_key = false;
			}
			else
			{
				SendKeys.Send(lower);
			}
		}

		private void type_email(string email)
		{
			textBox1.Focus();
			textBox1.Text += email;
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.SelectionLength = 0;
		}

		private void shift_button_Click(object sender, EventArgs e)
		{
			if (!shift_key)
			{
				shift_key = true;
			}
		}

		private void caps_lock_button_Click(object sender, EventArgs e)
		{
			if (!caps_lock_key)
			{
				caps_lock_key = true;
			}
			else
			{
				caps_lock_key = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			type_key("q", "Q");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			type_key("w", "W");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			type_key("e", "E");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			type_key("r", "R");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			type_key("t", "T");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			type_key("y", "Y");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			type_key("u", "U");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			type_key("i", "I");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			type_key("o", "O");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			type_key("p", "P");
		}

		private void button21_Click(object sender, EventArgs e)
		{
			type_key("a", "A");
		}

		private void button20_Click(object sender, EventArgs e)
		{
			type_key("s", "S");
		}

		private void button19_Click(object sender, EventArgs e)
		{
			type_key("d", "D");
		}

		private void button18_Click(object sender, EventArgs e)
		{
			type_key("f", "F");
		}

		private void button17_Click(object sender, EventArgs e)
		{
			type_key("g", "G");
		}

		private void button16_Click(object sender, EventArgs e)
		{
			type_key("h", "H");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			type_key("j", "J");
		}

		private void button14_Click(object sender, EventArgs e)
		{
			type_key("k", "K");
		}

		private void button13_Click(object sender, EventArgs e)
		{
			type_key("l", "L");
		}

		private void button12_Click(object sender, EventArgs e)
		{
			type_key("z", "Z");
		}

		private void button30_Click(object sender, EventArgs e)
		{
			type_key("x", "X");
		}

		private void button29_Click(object sender, EventArgs e)
		{
			type_key("c", "C");
		}

		private void button28_Click(object sender, EventArgs e)
		{
			type_key("v", "V");
		}

		private void button27_Click(object sender, EventArgs e)
		{
			type_key("b", "B");
		}

		private void button26_Click(object sender, EventArgs e)
		{
			type_key("n", "N");
		}

		private void button25_Click(object sender, EventArgs e)
		{
			type_key("m", "M");
		}

		private void button37_Click(object sender, EventArgs e)
		{
			type_key("1", "{!}");
		}

		private void button36_Click(object sender, EventArgs e)
		{
			type_key("2", "{@}");
		}

		private void button35_Click(object sender, EventArgs e)
		{
			type_key("3", "{#}");
		}

		private void button34_Click(object sender, EventArgs e)
		{
			type_key("4", "{$}");
		}

		private void button33_Click(object sender, EventArgs e)
		{
			type_key("5", "{%}");
		}

		private void button32_Click(object sender, EventArgs e)
		{
			type_key("6", "{^}");
		}

		private void button31_Click(object sender, EventArgs e)
		{
			type_key("7", "{&}");
		}

		private void button24_Click(object sender, EventArgs e)
		{
			type_key("8", "{*}");
		}

		private void button23_Click(object sender, EventArgs e)
		{
			type_key("9", "{(}");
		}

		private void button22_Click(object sender, EventArgs e)
		{
			type_key("0", "{)}");
		}

		private void button39_Click(object sender, EventArgs e)
		{
			type_key("{-}", "{_}");
		}

		private void button38_Click(object sender, EventArgs e)
		{
			type_key("{=}", "{+}");
		}

		private void button45_Click(object sender, EventArgs e)
		{
			type_key("{[}", "{{}");
		}

		private void button44_Click(object sender, EventArgs e)
		{
			type_key("{]}", "{}}");
		}

		private void button40_Click(object sender, EventArgs e)
		{
			type_key("{\\}", "{|}");
		}

		private void button42_Click(object sender, EventArgs e)
		{
			type_key("{;}", "{:}");
		}

		private void button41_Click(object sender, EventArgs e)
		{
			type_key("{'}", "{\"}");
		}

		private void button48_Click(object sender, EventArgs e)
		{
			type_key("{,}", "{<}");
		}

		private void button47_Click(object sender, EventArgs e)
		{
			type_key("{.}", "{>}");
		}

		private void button46_Click(object sender, EventArgs e)
		{
			type_key("{/}", "{?}");
		}

		private void button49_Click(object sender, EventArgs e)
		{
			type_key("{`}", "{~}");
		}

		private void button43_Click(object sender, EventArgs e)
		{
			textBox1.Focus();
			SendKeys.Send("{BACKSPACE}");
		}

		private void button50_Click(object sender, EventArgs e)
		{
			type_email("@gmail.com");
		}

		private void button51_Click(object sender, EventArgs e)
		{
			type_email("@yahoo.com");
		}

		private void button52_Click(object sender, EventArgs e)
		{
			type_email("@icloud.com");
		}

		private void button53_Click(object sender, EventArgs e)
		{
			type_email("@outlook.com");
		}

		private void button54_Click(object sender, EventArgs e)
		{
			type_email("@hotmail.com");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			button1 = new System.Windows.Forms.Button();
			textBox1 = new System.Windows.Forms.TextBox();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button7 = new System.Windows.Forms.Button();
			button8 = new System.Windows.Forms.Button();
			button9 = new System.Windows.Forms.Button();
			button10 = new System.Windows.Forms.Button();
			button11 = new System.Windows.Forms.Button();
			button12 = new System.Windows.Forms.Button();
			button13 = new System.Windows.Forms.Button();
			button14 = new System.Windows.Forms.Button();
			button15 = new System.Windows.Forms.Button();
			button16 = new System.Windows.Forms.Button();
			button17 = new System.Windows.Forms.Button();
			button18 = new System.Windows.Forms.Button();
			button19 = new System.Windows.Forms.Button();
			button20 = new System.Windows.Forms.Button();
			button21 = new System.Windows.Forms.Button();
			button25 = new System.Windows.Forms.Button();
			button26 = new System.Windows.Forms.Button();
			button27 = new System.Windows.Forms.Button();
			button28 = new System.Windows.Forms.Button();
			button29 = new System.Windows.Forms.Button();
			button30 = new System.Windows.Forms.Button();
			shift_button = new System.Windows.Forms.Button();
			caps_lock_button = new System.Windows.Forms.Button();
			button22 = new System.Windows.Forms.Button();
			button23 = new System.Windows.Forms.Button();
			button24 = new System.Windows.Forms.Button();
			button31 = new System.Windows.Forms.Button();
			button32 = new System.Windows.Forms.Button();
			button33 = new System.Windows.Forms.Button();
			button34 = new System.Windows.Forms.Button();
			button35 = new System.Windows.Forms.Button();
			button36 = new System.Windows.Forms.Button();
			button37 = new System.Windows.Forms.Button();
			button38 = new System.Windows.Forms.Button();
			button39 = new System.Windows.Forms.Button();
			button40 = new System.Windows.Forms.Button();
			button41 = new System.Windows.Forms.Button();
			button42 = new System.Windows.Forms.Button();
			button43 = new System.Windows.Forms.Button();
			button44 = new System.Windows.Forms.Button();
			button45 = new System.Windows.Forms.Button();
			button46 = new System.Windows.Forms.Button();
			button47 = new System.Windows.Forms.Button();
			button48 = new System.Windows.Forms.Button();
			button49 = new System.Windows.Forms.Button();
			button50 = new System.Windows.Forms.Button();
			button51 = new System.Windows.Forms.Button();
			button52 = new System.Windows.Forms.Button();
			button53 = new System.Windows.Forms.Button();
			button54 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			SuspendLayout();
			button1.BackColor = System.Drawing.Color.Black;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.Color.White;
			button1.Location = new System.Drawing.Point(580, 12);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(78, 49);
			button1.TabIndex = 0;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			textBox1.Location = new System.Drawing.Point(300, 20);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(272, 29);
			textBox1.TabIndex = 1;
			button2.BackColor = System.Drawing.Color.Black;
			button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.Color.White;
			button2.Location = new System.Drawing.Point(97, 128);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(52, 52);
			button2.TabIndex = 2;
			button2.Text = "Q";
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			button3.BackColor = System.Drawing.Color.Black;
			button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button3.ForeColor = System.Drawing.Color.White;
			button3.Location = new System.Drawing.Point(155, 128);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(52, 52);
			button3.TabIndex = 3;
			button3.Text = "W";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button4.BackColor = System.Drawing.Color.Black;
			button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button4.ForeColor = System.Drawing.Color.White;
			button4.Location = new System.Drawing.Point(213, 128);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(52, 52);
			button4.TabIndex = 4;
			button4.Text = "E";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			button5.BackColor = System.Drawing.Color.Black;
			button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button5.ForeColor = System.Drawing.Color.White;
			button5.Location = new System.Drawing.Point(271, 128);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(52, 52);
			button5.TabIndex = 5;
			button5.Text = "R";
			button5.UseVisualStyleBackColor = false;
			button5.Click += new System.EventHandler(button5_Click);
			button6.BackColor = System.Drawing.Color.Black;
			button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button6.ForeColor = System.Drawing.Color.White;
			button6.Location = new System.Drawing.Point(329, 128);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(52, 52);
			button6.TabIndex = 6;
			button6.Text = "T";
			button6.UseVisualStyleBackColor = false;
			button6.Click += new System.EventHandler(button6_Click);
			button7.BackColor = System.Drawing.Color.Black;
			button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button7.ForeColor = System.Drawing.Color.White;
			button7.Location = new System.Drawing.Point(561, 128);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(52, 52);
			button7.TabIndex = 10;
			button7.Text = "O";
			button7.UseVisualStyleBackColor = false;
			button7.Click += new System.EventHandler(button7_Click);
			button8.BackColor = System.Drawing.Color.Black;
			button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button8.ForeColor = System.Drawing.Color.White;
			button8.Location = new System.Drawing.Point(503, 128);
			button8.Name = "button8";
			button8.Size = new System.Drawing.Size(52, 52);
			button8.TabIndex = 9;
			button8.Text = "I";
			button8.UseVisualStyleBackColor = false;
			button8.Click += new System.EventHandler(button8_Click);
			button9.BackColor = System.Drawing.Color.Black;
			button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button9.ForeColor = System.Drawing.Color.White;
			button9.Location = new System.Drawing.Point(445, 128);
			button9.Name = "button9";
			button9.Size = new System.Drawing.Size(52, 52);
			button9.TabIndex = 8;
			button9.Text = "U";
			button9.UseVisualStyleBackColor = false;
			button9.Click += new System.EventHandler(button9_Click);
			button10.BackColor = System.Drawing.Color.Black;
			button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button10.ForeColor = System.Drawing.Color.White;
			button10.Location = new System.Drawing.Point(387, 128);
			button10.Name = "button10";
			button10.Size = new System.Drawing.Size(52, 52);
			button10.TabIndex = 7;
			button10.Text = "Y";
			button10.UseVisualStyleBackColor = false;
			button10.Click += new System.EventHandler(button10_Click);
			button11.BackColor = System.Drawing.Color.Black;
			button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button11.ForeColor = System.Drawing.Color.White;
			button11.Location = new System.Drawing.Point(619, 128);
			button11.Name = "button11";
			button11.Size = new System.Drawing.Size(52, 52);
			button11.TabIndex = 11;
			button11.Text = "P";
			button11.UseVisualStyleBackColor = false;
			button11.Click += new System.EventHandler(button11_Click);
			button12.BackColor = System.Drawing.Color.Black;
			button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button12.ForeColor = System.Drawing.Color.White;
			button12.Location = new System.Drawing.Point(205, 244);
			button12.Name = "button12";
			button12.Size = new System.Drawing.Size(52, 52);
			button12.TabIndex = 21;
			button12.Text = "Z";
			button12.UseVisualStyleBackColor = false;
			button12.Click += new System.EventHandler(button12_Click);
			button13.BackColor = System.Drawing.Color.Black;
			button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button13.ForeColor = System.Drawing.Color.White;
			button13.Location = new System.Drawing.Point(636, 185);
			button13.Name = "button13";
			button13.Size = new System.Drawing.Size(52, 52);
			button13.TabIndex = 20;
			button13.Text = "L";
			button13.UseVisualStyleBackColor = false;
			button13.Click += new System.EventHandler(button13_Click);
			button14.BackColor = System.Drawing.Color.Black;
			button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button14.ForeColor = System.Drawing.Color.White;
			button14.Location = new System.Drawing.Point(578, 185);
			button14.Name = "button14";
			button14.Size = new System.Drawing.Size(52, 52);
			button14.TabIndex = 19;
			button14.Text = "K";
			button14.UseVisualStyleBackColor = false;
			button14.Click += new System.EventHandler(button14_Click);
			button15.BackColor = System.Drawing.Color.Black;
			button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button15.ForeColor = System.Drawing.Color.White;
			button15.Location = new System.Drawing.Point(520, 185);
			button15.Name = "button15";
			button15.Size = new System.Drawing.Size(52, 52);
			button15.TabIndex = 18;
			button15.Text = "J";
			button15.UseVisualStyleBackColor = false;
			button15.Click += new System.EventHandler(button15_Click);
			button16.BackColor = System.Drawing.Color.Black;
			button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button16.ForeColor = System.Drawing.Color.White;
			button16.Location = new System.Drawing.Point(462, 185);
			button16.Name = "button16";
			button16.Size = new System.Drawing.Size(52, 52);
			button16.TabIndex = 17;
			button16.Text = "H";
			button16.UseVisualStyleBackColor = false;
			button16.Click += new System.EventHandler(button16_Click);
			button17.BackColor = System.Drawing.Color.Black;
			button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button17.ForeColor = System.Drawing.Color.White;
			button17.Location = new System.Drawing.Point(404, 185);
			button17.Name = "button17";
			button17.Size = new System.Drawing.Size(52, 52);
			button17.TabIndex = 16;
			button17.Text = "G";
			button17.UseVisualStyleBackColor = false;
			button17.Click += new System.EventHandler(button17_Click);
			button18.BackColor = System.Drawing.Color.Black;
			button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button18.ForeColor = System.Drawing.Color.White;
			button18.Location = new System.Drawing.Point(346, 185);
			button18.Name = "button18";
			button18.Size = new System.Drawing.Size(52, 52);
			button18.TabIndex = 15;
			button18.Text = "F";
			button18.UseVisualStyleBackColor = false;
			button18.Click += new System.EventHandler(button18_Click);
			button19.BackColor = System.Drawing.Color.Black;
			button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button19.ForeColor = System.Drawing.Color.White;
			button19.Location = new System.Drawing.Point(288, 185);
			button19.Name = "button19";
			button19.Size = new System.Drawing.Size(52, 52);
			button19.TabIndex = 14;
			button19.Text = "D";
			button19.UseVisualStyleBackColor = false;
			button19.Click += new System.EventHandler(button19_Click);
			button20.BackColor = System.Drawing.Color.Black;
			button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button20.ForeColor = System.Drawing.Color.White;
			button20.Location = new System.Drawing.Point(230, 185);
			button20.Name = "button20";
			button20.Size = new System.Drawing.Size(52, 52);
			button20.TabIndex = 13;
			button20.Text = "S";
			button20.UseVisualStyleBackColor = false;
			button20.Click += new System.EventHandler(button20_Click);
			button21.BackColor = System.Drawing.Color.Black;
			button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button21.ForeColor = System.Drawing.Color.White;
			button21.Location = new System.Drawing.Point(172, 185);
			button21.Name = "button21";
			button21.Size = new System.Drawing.Size(52, 52);
			button21.TabIndex = 12;
			button21.Text = "A";
			button21.UseVisualStyleBackColor = false;
			button21.Click += new System.EventHandler(button21_Click);
			button25.BackColor = System.Drawing.Color.Black;
			button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button25.ForeColor = System.Drawing.Color.White;
			button25.Location = new System.Drawing.Point(553, 244);
			button25.Name = "button25";
			button25.Size = new System.Drawing.Size(52, 52);
			button25.TabIndex = 27;
			button25.Text = "M";
			button25.UseVisualStyleBackColor = false;
			button25.Click += new System.EventHandler(button25_Click);
			button26.BackColor = System.Drawing.Color.Black;
			button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button26.ForeColor = System.Drawing.Color.White;
			button26.Location = new System.Drawing.Point(495, 244);
			button26.Name = "button26";
			button26.Size = new System.Drawing.Size(52, 52);
			button26.TabIndex = 26;
			button26.Text = "N";
			button26.UseVisualStyleBackColor = false;
			button26.Click += new System.EventHandler(button26_Click);
			button27.BackColor = System.Drawing.Color.Black;
			button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button27.ForeColor = System.Drawing.Color.White;
			button27.Location = new System.Drawing.Point(437, 244);
			button27.Name = "button27";
			button27.Size = new System.Drawing.Size(52, 52);
			button27.TabIndex = 25;
			button27.Text = "B";
			button27.UseVisualStyleBackColor = false;
			button27.Click += new System.EventHandler(button27_Click);
			button28.BackColor = System.Drawing.Color.Black;
			button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button28.ForeColor = System.Drawing.Color.White;
			button28.Location = new System.Drawing.Point(379, 244);
			button28.Name = "button28";
			button28.Size = new System.Drawing.Size(52, 52);
			button28.TabIndex = 24;
			button28.Text = "V";
			button28.UseVisualStyleBackColor = false;
			button28.Click += new System.EventHandler(button28_Click);
			button29.BackColor = System.Drawing.Color.Black;
			button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button29.ForeColor = System.Drawing.Color.White;
			button29.Location = new System.Drawing.Point(321, 244);
			button29.Name = "button29";
			button29.Size = new System.Drawing.Size(52, 52);
			button29.TabIndex = 23;
			button29.Text = "C";
			button29.UseVisualStyleBackColor = false;
			button29.Click += new System.EventHandler(button29_Click);
			button30.BackColor = System.Drawing.Color.Black;
			button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button30.ForeColor = System.Drawing.Color.White;
			button30.Location = new System.Drawing.Point(263, 244);
			button30.Name = "button30";
			button30.Size = new System.Drawing.Size(52, 52);
			button30.TabIndex = 22;
			button30.Text = "X";
			button30.UseVisualStyleBackColor = false;
			button30.Click += new System.EventHandler(button30_Click);
			shift_button.BackColor = System.Drawing.Color.Black;
			shift_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			shift_button.ForeColor = System.Drawing.Color.White;
			shift_button.Location = new System.Drawing.Point(97, 244);
			shift_button.Name = "shift_button";
			shift_button.Size = new System.Drawing.Size(102, 52);
			shift_button.TabIndex = 28;
			shift_button.Text = "Shift";
			shift_button.UseVisualStyleBackColor = false;
			shift_button.Click += new System.EventHandler(shift_button_Click);
			caps_lock_button.BackColor = System.Drawing.Color.Black;
			caps_lock_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			caps_lock_button.ForeColor = System.Drawing.Color.White;
			caps_lock_button.Location = new System.Drawing.Point(46, 185);
			caps_lock_button.Name = "caps_lock_button";
			caps_lock_button.Size = new System.Drawing.Size(120, 53);
			caps_lock_button.TabIndex = 29;
			caps_lock_button.Text = "Caps Lock";
			caps_lock_button.UseVisualStyleBackColor = false;
			caps_lock_button.Click += new System.EventHandler(caps_lock_button_Click);
			button22.BackColor = System.Drawing.Color.Black;
			button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button22.ForeColor = System.Drawing.Color.White;
			button22.Location = new System.Drawing.Point(629, 70);
			button22.Name = "button22";
			button22.Size = new System.Drawing.Size(52, 52);
			button22.TabIndex = 39;
			button22.Text = ")\r\n0";
			button22.UseVisualStyleBackColor = false;
			button22.Click += new System.EventHandler(button22_Click);
			button23.BackColor = System.Drawing.Color.Black;
			button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button23.ForeColor = System.Drawing.Color.White;
			button23.Location = new System.Drawing.Point(571, 70);
			button23.Name = "button23";
			button23.Size = new System.Drawing.Size(52, 52);
			button23.TabIndex = 38;
			button23.Text = "(\r\n9";
			button23.UseVisualStyleBackColor = false;
			button23.Click += new System.EventHandler(button23_Click);
			button24.BackColor = System.Drawing.Color.Black;
			button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button24.ForeColor = System.Drawing.Color.White;
			button24.Location = new System.Drawing.Point(513, 70);
			button24.Name = "button24";
			button24.Size = new System.Drawing.Size(52, 52);
			button24.TabIndex = 37;
			button24.Text = "*\r\n8";
			button24.UseVisualStyleBackColor = false;
			button24.Click += new System.EventHandler(button24_Click);
			button31.BackColor = System.Drawing.Color.Black;
			button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button31.ForeColor = System.Drawing.Color.White;
			button31.Location = new System.Drawing.Point(455, 70);
			button31.Name = "button31";
			button31.Size = new System.Drawing.Size(52, 52);
			button31.TabIndex = 36;
			button31.Text = "&&\r\n7";
			button31.UseVisualStyleBackColor = false;
			button31.Click += new System.EventHandler(button31_Click);
			button32.BackColor = System.Drawing.Color.Black;
			button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button32.ForeColor = System.Drawing.Color.White;
			button32.Location = new System.Drawing.Point(397, 70);
			button32.Name = "button32";
			button32.Size = new System.Drawing.Size(52, 52);
			button32.TabIndex = 35;
			button32.Text = "^\r\n6";
			button32.UseVisualStyleBackColor = false;
			button32.Click += new System.EventHandler(button32_Click);
			button33.BackColor = System.Drawing.Color.Black;
			button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button33.ForeColor = System.Drawing.Color.White;
			button33.Location = new System.Drawing.Point(339, 70);
			button33.Name = "button33";
			button33.Size = new System.Drawing.Size(52, 52);
			button33.TabIndex = 34;
			button33.Text = "%\r\n5";
			button33.UseVisualStyleBackColor = false;
			button33.Click += new System.EventHandler(button33_Click);
			button34.BackColor = System.Drawing.Color.Black;
			button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button34.ForeColor = System.Drawing.Color.White;
			button34.Location = new System.Drawing.Point(281, 70);
			button34.Name = "button34";
			button34.Size = new System.Drawing.Size(52, 52);
			button34.TabIndex = 33;
			button34.Text = "$\r\n4";
			button34.UseVisualStyleBackColor = false;
			button34.Click += new System.EventHandler(button34_Click);
			button35.BackColor = System.Drawing.Color.Black;
			button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button35.ForeColor = System.Drawing.Color.White;
			button35.Location = new System.Drawing.Point(223, 70);
			button35.Name = "button35";
			button35.Size = new System.Drawing.Size(52, 52);
			button35.TabIndex = 32;
			button35.Text = "#\r\n3";
			button35.UseVisualStyleBackColor = false;
			button35.Click += new System.EventHandler(button35_Click);
			button36.BackColor = System.Drawing.Color.Black;
			button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button36.ForeColor = System.Drawing.Color.White;
			button36.Location = new System.Drawing.Point(165, 70);
			button36.Name = "button36";
			button36.Size = new System.Drawing.Size(52, 52);
			button36.TabIndex = 31;
			button36.Text = "@\r\n2";
			button36.UseVisualStyleBackColor = false;
			button36.Click += new System.EventHandler(button36_Click);
			button37.BackColor = System.Drawing.Color.Black;
			button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button37.ForeColor = System.Drawing.Color.White;
			button37.Location = new System.Drawing.Point(107, 70);
			button37.Name = "button37";
			button37.Size = new System.Drawing.Size(52, 52);
			button37.TabIndex = 30;
			button37.Text = "!\r\n1";
			button37.UseVisualStyleBackColor = false;
			button37.Click += new System.EventHandler(button37_Click);
			button38.BackColor = System.Drawing.Color.Black;
			button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button38.ForeColor = System.Drawing.Color.White;
			button38.Location = new System.Drawing.Point(745, 70);
			button38.Name = "button38";
			button38.Size = new System.Drawing.Size(52, 52);
			button38.TabIndex = 41;
			button38.Text = "+\r\n=";
			button38.UseVisualStyleBackColor = false;
			button38.Click += new System.EventHandler(button38_Click);
			button39.BackColor = System.Drawing.Color.Black;
			button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button39.ForeColor = System.Drawing.Color.White;
			button39.Location = new System.Drawing.Point(687, 70);
			button39.Name = "button39";
			button39.Size = new System.Drawing.Size(52, 52);
			button39.TabIndex = 40;
			button39.Text = "_\r\n-";
			button39.UseVisualStyleBackColor = false;
			button39.Click += new System.EventHandler(button39_Click);
			button40.BackColor = System.Drawing.Color.Black;
			button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button40.ForeColor = System.Drawing.Color.White;
			button40.Location = new System.Drawing.Point(793, 128);
			button40.Name = "button40";
			button40.Size = new System.Drawing.Size(52, 52);
			button40.TabIndex = 44;
			button40.Text = "|\r\n\\";
			button40.UseVisualStyleBackColor = false;
			button40.Click += new System.EventHandler(button40_Click);
			button41.BackColor = System.Drawing.Color.Black;
			button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button41.ForeColor = System.Drawing.Color.White;
			button41.Location = new System.Drawing.Point(754, 186);
			button41.Name = "button41";
			button41.Size = new System.Drawing.Size(52, 52);
			button41.TabIndex = 43;
			button41.Text = "\"\r\n'";
			button41.UseVisualStyleBackColor = false;
			button41.Click += new System.EventHandler(button41_Click);
			button42.BackColor = System.Drawing.Color.Black;
			button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button42.ForeColor = System.Drawing.Color.White;
			button42.Location = new System.Drawing.Point(694, 186);
			button42.Name = "button42";
			button42.Size = new System.Drawing.Size(52, 52);
			button42.TabIndex = 42;
			button42.Text = ":\r\n;";
			button42.UseVisualStyleBackColor = false;
			button42.Click += new System.EventHandler(button42_Click);
			button43.BackColor = System.Drawing.Color.Black;
			button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button43.ForeColor = System.Drawing.Color.White;
			button43.Location = new System.Drawing.Point(803, 70);
			button43.Name = "button43";
			button43.Size = new System.Drawing.Size(96, 52);
			button43.TabIndex = 45;
			button43.Text = "Backspace";
			button43.UseVisualStyleBackColor = false;
			button43.Click += new System.EventHandler(button43_Click);
			button44.BackColor = System.Drawing.Color.Black;
			button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button44.ForeColor = System.Drawing.Color.White;
			button44.Location = new System.Drawing.Point(733, 128);
			button44.Name = "button44";
			button44.Size = new System.Drawing.Size(52, 52);
			button44.TabIndex = 47;
			button44.Text = "}\r\n]";
			button44.UseVisualStyleBackColor = false;
			button44.Click += new System.EventHandler(button44_Click);
			button45.BackColor = System.Drawing.Color.Black;
			button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button45.ForeColor = System.Drawing.Color.White;
			button45.Location = new System.Drawing.Point(675, 128);
			button45.Name = "button45";
			button45.Size = new System.Drawing.Size(52, 52);
			button45.TabIndex = 46;
			button45.Text = "{\r\n[";
			button45.UseVisualStyleBackColor = false;
			button45.Click += new System.EventHandler(button45_Click);
			button46.BackColor = System.Drawing.Color.Black;
			button46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button46.ForeColor = System.Drawing.Color.White;
			button46.Location = new System.Drawing.Point(727, 244);
			button46.Name = "button46";
			button46.Size = new System.Drawing.Size(52, 52);
			button46.TabIndex = 50;
			button46.Text = "?\r\n/";
			button46.UseVisualStyleBackColor = false;
			button46.Click += new System.EventHandler(button46_Click);
			button47.BackColor = System.Drawing.Color.Black;
			button47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button47.ForeColor = System.Drawing.Color.White;
			button47.Location = new System.Drawing.Point(669, 244);
			button47.Name = "button47";
			button47.Size = new System.Drawing.Size(52, 52);
			button47.TabIndex = 49;
			button47.Text = ">\r\n.";
			button47.UseVisualStyleBackColor = false;
			button47.Click += new System.EventHandler(button47_Click);
			button48.BackColor = System.Drawing.Color.Black;
			button48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button48.ForeColor = System.Drawing.Color.White;
			button48.Location = new System.Drawing.Point(611, 244);
			button48.Name = "button48";
			button48.Size = new System.Drawing.Size(52, 52);
			button48.TabIndex = 48;
			button48.Text = "<\r\n,";
			button48.UseVisualStyleBackColor = false;
			button48.Click += new System.EventHandler(button48_Click);
			button49.BackColor = System.Drawing.Color.Black;
			button49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button49.ForeColor = System.Drawing.Color.White;
			button49.Location = new System.Drawing.Point(49, 70);
			button49.Name = "button49";
			button49.Size = new System.Drawing.Size(52, 52);
			button49.TabIndex = 51;
			button49.Text = "~\r\n`";
			button49.UseVisualStyleBackColor = false;
			button49.Click += new System.EventHandler(button49_Click);
			button50.BackColor = System.Drawing.Color.Black;
			button50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button50.ForeColor = System.Drawing.Color.White;
			button50.Location = new System.Drawing.Point(120, 302);
			button50.Name = "button50";
			button50.Size = new System.Drawing.Size(113, 52);
			button50.TabIndex = 52;
			button50.Text = "@gmail.com";
			button50.UseVisualStyleBackColor = false;
			button50.Click += new System.EventHandler(button50_Click);
			button51.BackColor = System.Drawing.Color.Black;
			button51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button51.ForeColor = System.Drawing.Color.White;
			button51.Location = new System.Drawing.Point(239, 302);
			button51.Name = "button51";
			button51.Size = new System.Drawing.Size(127, 52);
			button51.TabIndex = 53;
			button51.Text = "@yahoo.com";
			button51.UseVisualStyleBackColor = false;
			button51.Click += new System.EventHandler(button51_Click);
			button52.BackColor = System.Drawing.Color.Black;
			button52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button52.ForeColor = System.Drawing.Color.White;
			button52.Location = new System.Drawing.Point(372, 302);
			button52.Name = "button52";
			button52.Size = new System.Drawing.Size(127, 52);
			button52.TabIndex = 54;
			button52.Text = "@icloud.com";
			button52.UseVisualStyleBackColor = false;
			button52.Click += new System.EventHandler(button52_Click);
			button53.BackColor = System.Drawing.Color.Black;
			button53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button53.ForeColor = System.Drawing.Color.White;
			button53.Location = new System.Drawing.Point(505, 302);
			button53.Name = "button53";
			button53.Size = new System.Drawing.Size(127, 52);
			button53.TabIndex = 55;
			button53.Text = "@outlook.com";
			button53.UseVisualStyleBackColor = false;
			button53.Click += new System.EventHandler(button53_Click);
			button54.BackColor = System.Drawing.Color.Black;
			button54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button54.ForeColor = System.Drawing.Color.White;
			button54.Location = new System.Drawing.Point(637, 302);
			button54.Name = "button54";
			button54.Size = new System.Drawing.Size(127, 52);
			button54.TabIndex = 56;
			button54.Text = "@hotmail.com";
			button54.UseVisualStyleBackColor = false;
			button54.Click += new System.EventHandler(button54_Click);
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(208, 16);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(86, 31);
			label1.TabIndex = 57;
			label1.Text = "Email";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Black;
			BackgroundImage = mission_board_keyboard.Properties.Resources.cropped_capa;
			base.Controls.Add(label1);
			base.Controls.Add(button54);
			base.Controls.Add(button53);
			base.Controls.Add(button52);
			base.Controls.Add(button51);
			base.Controls.Add(button50);
			base.Controls.Add(button49);
			base.Controls.Add(button46);
			base.Controls.Add(button47);
			base.Controls.Add(button48);
			base.Controls.Add(button44);
			base.Controls.Add(button45);
			base.Controls.Add(button43);
			base.Controls.Add(button40);
			base.Controls.Add(button41);
			base.Controls.Add(button42);
			base.Controls.Add(button38);
			base.Controls.Add(button39);
			base.Controls.Add(button22);
			base.Controls.Add(button23);
			base.Controls.Add(button24);
			base.Controls.Add(button31);
			base.Controls.Add(button32);
			base.Controls.Add(button33);
			base.Controls.Add(button34);
			base.Controls.Add(button35);
			base.Controls.Add(button36);
			base.Controls.Add(button37);
			base.Controls.Add(caps_lock_button);
			base.Controls.Add(shift_button);
			base.Controls.Add(button25);
			base.Controls.Add(button26);
			base.Controls.Add(button27);
			base.Controls.Add(button28);
			base.Controls.Add(button29);
			base.Controls.Add(button30);
			base.Controls.Add(button12);
			base.Controls.Add(button13);
			base.Controls.Add(button14);
			base.Controls.Add(button15);
			base.Controls.Add(button16);
			base.Controls.Add(button17);
			base.Controls.Add(button18);
			base.Controls.Add(button19);
			base.Controls.Add(button20);
			base.Controls.Add(button21);
			base.Controls.Add(button11);
			base.Controls.Add(button7);
			base.Controls.Add(button8);
			base.Controls.Add(button9);
			base.Controls.Add(button10);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(button3);
			base.Controls.Add(button2);
			base.Controls.Add(textBox1);
			base.Controls.Add(button1);
			DoubleBuffered = true;
			base.Name = "keyboard";
			base.Size = new System.Drawing.Size(918, 382);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}
	}
}
