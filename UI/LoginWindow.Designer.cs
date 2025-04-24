namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBG = new PictureBox();
            labelSI = new Label();
            labelAU = new Label();
            labelInfo = new Label();
            labelE = new Label();
            labelO = new Label();
            linklabelRM = new LinkLabel();
            linklabelTAP = new LinkLabel();
            checkboxKMLI = new CheckBox();
            linklabelFP = new LinkLabel();
            labelP = new Label();
            textBoxNewPassword = new TextBox();
            roundedBox1 = new RoundedBox();
            textBox1 = new TextBox();
            roundedBox2 = new RoundedBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            SuspendLayout();
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Image = Properties.Resources.LoginBG;
            pictureBG.Location = new Point(-1, -1);
            pictureBG.Margin = new Padding(3, 2, 3, 2);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1205, 1067);
            pictureBG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBG.TabIndex = 0;
            pictureBG.TabStop = false;
            pictureBG.Click += pictureBG_Click;
            // 
            // labelSI
            // 
            labelSI.AutoSize = true;
            labelSI.BackColor = Color.Transparent;
            labelSI.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelSI.ForeColor = SystemColors.ButtonHighlight;
            labelSI.Location = new Point(758, 145);
            labelSI.Name = "labelSI";
            labelSI.Size = new Size(158, 55);
            labelSI.TabIndex = 11;
            labelSI.Text = "Sign In";
            // 
            // labelAU
            // 
            labelAU.AutoSize = true;
            labelAU.BackColor = Color.Transparent;
            labelAU.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelAU.ForeColor = SystemColors.ControlText;
            labelAU.Location = new Point(276, 145);
            labelAU.Name = "labelAU";
            labelAU.Size = new Size(203, 55);
            labelAU.TabIndex = 11;
            labelAU.Text = "About Us";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Segoe UI", 13.8F);
            labelInfo.ForeColor = SystemColors.ControlText;
            labelInfo.Location = new Point(251, 243);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(262, 225);
            labelInfo.TabIndex = 11;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // labelE
            // 
            labelE.AutoSize = true;
            labelE.BackColor = Color.Transparent;
            labelE.Font = new Font("Segoe UI", 13.8F);
            labelE.ForeColor = SystemColors.ButtonHighlight;
            labelE.Location = new Point(682, 243);
            labelE.Name = "labelE";
            labelE.Size = new Size(58, 25);
            labelE.TabIndex = 11;
            labelE.Text = "Email";
            // 
            // labelO
            // 
            labelO.AutoSize = true;
            labelO.BackColor = Color.Transparent;
            labelO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelO.ForeColor = SystemColors.ButtonHighlight;
            labelO.Location = new Point(846, 498);
            labelO.Name = "labelO";
            labelO.Size = new Size(34, 25);
            labelO.TabIndex = 11;
            labelO.Text = "Or";
            // 
            // linklabelRM
            // 
            linklabelRM.AutoSize = true;
            linklabelRM.Font = new Font("Segoe UI", 10F);
            linklabelRM.LinkColor = Color.Black;
            linklabelRM.Location = new Point(338, 523);
            linklabelRM.Name = "linklabelRM";
            linklabelRM.Size = new Size(76, 19);
            linklabelRM.TabIndex = 14;
            linklabelRM.TabStop = true;
            linklabelRM.Text = "Read More";
            // 
            // linklabelTAP
            // 
            linklabelTAP.AutoSize = true;
            linklabelTAP.Font = new Font("Segoe UI", 10F);
            linklabelTAP.LinkColor = Color.White;
            linklabelTAP.Location = new Point(797, 545);
            linklabelTAP.Name = "linklabelTAP";
            linklabelTAP.Size = new Size(119, 19);
            linklabelTAP.TabIndex = 14;
            linklabelTAP.TabStop = true;
            linklabelTAP.Text = "Terms and Policies";
            linklabelTAP.LinkClicked += linklabelTAP_LinkClicked;
            // 
            // checkboxKMLI
            // 
            checkboxKMLI.AutoSize = true;
            checkboxKMLI.BackColor = Color.Transparent;
            checkboxKMLI.Font = new Font("Segoe UI", 12F);
            checkboxKMLI.ForeColor = SystemColors.ButtonHighlight;
            checkboxKMLI.Location = new Point(682, 432);
            checkboxKMLI.Margin = new Padding(3, 2, 3, 2);
            checkboxKMLI.Name = "checkboxKMLI";
            checkboxKMLI.Size = new Size(158, 25);
            checkboxKMLI.TabIndex = 15;
            checkboxKMLI.Text = "Keep me logged in";
            checkboxKMLI.UseVisualStyleBackColor = false;
            // 
            // linklabelFP
            // 
            linklabelFP.AutoSize = true;
            linklabelFP.Font = new Font("Segoe UI", 12F);
            linklabelFP.LinkColor = Color.White;
            linklabelFP.Location = new Point(898, 436);
            linklabelFP.Name = "linklabelFP";
            linklabelFP.Size = new Size(127, 21);
            linklabelFP.TabIndex = 14;
            linklabelFP.TabStop = true;
            linklabelFP.Text = "Forgot password";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = Color.Transparent;
            labelP.Font = new Font("Segoe UI", 13.8F);
            labelP.ForeColor = SystemColors.ButtonHighlight;
            labelP.Location = new Point(682, 342);
            labelP.Name = "labelP";
            labelP.Size = new Size(91, 25);
            labelP.TabIndex = 11;
            labelP.Text = "Password";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(691, 283);
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(327, 34);
            textBoxNewPassword.TabIndex = 65;
            // 
            // roundedBox1
            // 
            roundedBox1.BackColor = Color.Transparent;
            roundedBox1.BorderColor = Color.Black;
            roundedBox1.BorderRadius = 15;
            roundedBox1.BorderWidth = 2;
            roundedBox1.Location = new Point(683, 276);
            roundedBox1.Margin = new Padding(3, 2, 3, 2);
            roundedBox1.Name = "roundedBox1";
            roundedBox1.Size = new Size(342, 47);
            roundedBox1.TabIndex = 64;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(691, 381);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 34);
            textBox1.TabIndex = 67;
            // 
            // roundedBox2
            // 
            roundedBox2.BackColor = Color.Transparent;
            roundedBox2.BorderColor = Color.Black;
            roundedBox2.BorderRadius = 15;
            roundedBox2.BorderWidth = 2;
            roundedBox2.Location = new Point(683, 374);
            roundedBox2.Margin = new Padding(3, 2, 3, 2);
            roundedBox2.Name = "roundedBox2";
            roundedBox2.Size = new Size(342, 47);
            roundedBox2.TabIndex = 66;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 9;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(683, 485);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(151, 45);
            guna2Button1.TabIndex = 74;
            guna2Button1.Text = "Sign in";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 9;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Black;
            guna2Button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(889, 485);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(136, 45);
            guna2Button2.TabIndex = 75;
            guna2Button2.Text = "Sign up";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 665);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(textBox1);
            Controls.Add(roundedBox2);
            Controls.Add(textBoxNewPassword);
            Controls.Add(roundedBox1);
            Controls.Add(checkboxKMLI);
            Controls.Add(linklabelFP);
            Controls.Add(linklabelTAP);
            Controls.Add(linklabelRM);
            Controls.Add(labelP);
            Controls.Add(labelO);
            Controls.Add(labelE);
            Controls.Add(labelInfo);
            Controls.Add(labelAU);
            Controls.Add(labelSI);
            Controls.Add(pictureBG);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBG;
        private Label labelSI;
        private Label labelAU;
        private Label labelInfo;
        private Label labelE;
        private Label labelO;
        private LinkLabel linklabelRM;
        private LinkLabel linklabelTAP;
        private CheckBox checkboxKMLI;
        private LinkLabel linklabelFP;
        private Label labelP;
        private TextBox textBoxNewPassword;
        private RoundedBox roundedBox1;
        private TextBox textBox1;
        private RoundedBox roundedBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}