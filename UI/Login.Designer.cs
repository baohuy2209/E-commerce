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
            pictureBG = new PictureBox();
            labelLogin = new Label();
            labelAU = new Label();
            labelInfo = new Label();
            textboxEmail = new TextBox();
            textboxPassword = new TextBox();
            labelE = new Label();
            labelP = new Label();
            buttonLogin = new Button();
            linklabelTAP = new LinkLabel();
            checkboxTAP = new CheckBox();
            linkLabelRM = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            SuspendLayout();
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImage = Properties.Resources.LoginBG;
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Location = new Point(-1, -1);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1377, 1423);
            pictureBG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBG.TabIndex = 0;
            pictureBG.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelLogin.ForeColor = SystemColors.ButtonHighlight;
            labelLogin.Location = new Point(903, 193);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(163, 68);
            labelLogin.TabIndex = 11;
            labelLogin.Text = "Login";
            // 
            // labelAU
            // 
            labelAU.AutoSize = true;
            labelAU.BackColor = Color.Transparent;
            labelAU.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelAU.ForeColor = SystemColors.ControlText;
            labelAU.Location = new Point(315, 193);
            labelAU.Name = "labelAU";
            labelAU.Size = new Size(252, 68);
            labelAU.TabIndex = 11;
            labelAU.Text = "About Us";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Segoe UI", 13.8F);
            labelInfo.ForeColor = SystemColors.ControlText;
            labelInfo.Location = new Point(287, 324);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(317, 279);
            labelInfo.TabIndex = 11;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // textboxEmail
            // 
            textboxEmail.Font = new Font("Segoe UI", 14F);
            textboxEmail.Location = new Point(780, 358);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(383, 39);
            textboxEmail.TabIndex = 12;
            // 
            // textboxPassword
            // 
            textboxPassword.Font = new Font("Segoe UI", 14F);
            textboxPassword.Location = new Point(780, 490);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.Size = new Size(383, 39);
            textboxPassword.TabIndex = 12;
            // 
            // labelE
            // 
            labelE.AutoSize = true;
            labelE.BackColor = Color.Transparent;
            labelE.Font = new Font("Segoe UI", 13.8F);
            labelE.ForeColor = SystemColors.ButtonHighlight;
            labelE.Location = new Point(780, 324);
            labelE.Name = "labelE";
            labelE.Size = new Size(70, 31);
            labelE.TabIndex = 11;
            labelE.Text = "Email";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = Color.Transparent;
            labelP.Font = new Font("Segoe UI", 13.8F);
            labelP.ForeColor = SystemColors.ButtonHighlight;
            labelP.Location = new Point(780, 456);
            labelP.Name = "labelP";
            labelP.Size = new Size(110, 31);
            labelP.TabIndex = 11;
            labelP.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(936, 637);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(101, 48);
            buttonLogin.TabIndex = 13;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // linklabelTAP
            // 
            linklabelTAP.AutoSize = true;
            linklabelTAP.Font = new Font("Segoe UI", 10F);
            linklabelTAP.LinkColor = Color.White;
            linklabelTAP.Location = new Point(912, 697);
            linklabelTAP.Name = "linklabelTAP";
            linklabelTAP.Size = new Size(148, 23);
            linklabelTAP.TabIndex = 14;
            linklabelTAP.TabStop = true;
            linklabelTAP.Text = "Terms and Policies";
            // 
            // checkboxTAP
            // 
            checkboxTAP.AutoSize = true;
            checkboxTAP.BackColor = Color.Transparent;
            checkboxTAP.ForeColor = SystemColors.ButtonHighlight;
            checkboxTAP.Location = new Point(780, 554);
            checkboxTAP.Name = "checkboxTAP";
            checkboxTAP.Size = new Size(228, 24);
            checkboxTAP.TabIndex = 15;
            checkboxTAP.Text = "I accept all Terms and Policies";
            checkboxTAP.UseVisualStyleBackColor = false;
            // 
            // linkLabelRM
            // 
            linkLabelRM.AutoSize = true;
            linkLabelRM.Font = new Font("Segoe UI", 10F);
            linkLabelRM.LinkColor = Color.Black;
            linkLabelRM.Location = new Point(386, 697);
            linkLabelRM.Name = "linkLabelRM";
            linkLabelRM.Size = new Size(93, 23);
            linkLabelRM.TabIndex = 14;
            linkLabelRM.TabStop = true;
            linkLabelRM.Text = "Read More";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 887);
            Controls.Add(checkboxTAP);
            Controls.Add(linkLabelRM);
            Controls.Add(linklabelTAP);
            Controls.Add(buttonLogin);
            Controls.Add(textboxPassword);
            Controls.Add(textboxEmail);
            Controls.Add(labelP);
            Controls.Add(labelE);
            Controls.Add(labelInfo);
            Controls.Add(labelAU);
            Controls.Add(labelLogin);
            Controls.Add(pictureBG);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBG;
        private Label labelLogin;
        private Label labelAU;
        private Label labelInfo;
        private TextBox textboxEmail;
        private TextBox textboxPassword;
        private Label labelE;
        private Label labelP;
        private Button buttonLogin;
        private LinkLabel linklabelTAP;
        private CheckBox checkboxTAP;
        private LinkLabel linkLabelRM;
    }
}