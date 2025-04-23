namespace UI
{
    partial class SignupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupWindow));
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label11 = new Label();
            label10 = new Label();
            button1 = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            monthCalendar2 = new MonthCalendar();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            printDialog1 = new PrintDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(monthCalendar2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(491, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 704);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign up";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(24, 521);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(280, 29);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Accept our terms and policies";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(222, 659);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 25);
            linkLabel1.TabIndex = 41;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login here";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(24, 660);
            label11.Name = "label11";
            label11.Size = new Size(207, 25);
            label11.TabIndex = 40;
            label11.Text = "Already have account? ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(72, 521);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 38;
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(216, 573);
            button1.Name = "button1";
            button1.Size = new Size(293, 55);
            button1.TabIndex = 36;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(376, 137);
            label9.Name = "label9";
            label9.Size = new Size(97, 31);
            label9.TabIndex = 35;
            label9.Text = "Address";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(378, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 39);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(376, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 39);
            textBox6.TabIndex = 34;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthCalendar2.Location = new Point(387, 366);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(20, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(335, 39);
            textBox5.TabIndex = 31;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(20, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 39);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(24, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 39);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 463);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 39);
            textBox1.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(23, 427);
            label6.Name = "label6";
            label6.Size = new Size(197, 31);
            label6.TabIndex = 27;
            label6.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(387, 46);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 26;
            label2.Text = "Gender";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(376, 228);
            label8.Name = "label8";
            label8.Size = new Size(154, 31);
            label8.TabIndex = 25;
            label8.Text = "First Buy Date";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(20, 326);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 24;
            label7.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(24, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(331, 39);
            textBox4.TabIndex = 23;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(387, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 36);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.UseWaitCursor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(509, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(109, 36);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.UseWaitCursor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(20, 228);
            label5.Name = "label5";
            label5.Size = new Size(168, 31);
            label5.TabIndex = 17;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(18, 138);
            label3.Name = "label3";
            label3.Size = new Size(159, 31);
            label3.TabIndex = 16;
            label3.Text = "Email Address";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(376, 326);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 14;
            label1.Text = "D.O.B";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(18, 53);
            label4.Name = "label4";
            label4.Size = new Size(117, 31);
            label4.TabIndex = 8;
            label4.Text = "Full Name";
            label4.Click += label4_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // SignupWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 794);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignupWindow";
            Text = "Register";
            Load += RegisterWindow_Load;
            BackColorChanged += label1_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private PrintDialog printDialog1;
        private Label label4;
        private Label label1;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label8;
        private Label label7;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox textBox6;
        private MonthCalendar monthCalendar2;
        private Button button1;
        private Label label10;
        private Label label11;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
    }
}