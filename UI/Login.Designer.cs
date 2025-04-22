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
            labelSI = new Label();
            labelAU = new Label();
            labelInfo = new Label();
            textboxEmail = new TextBox();
            textboxPassword = new TextBox();
            labelE = new Label();
            labelO = new Label();
            buttonSI = new Button();
            linklabelRM = new LinkLabel();
            linklabelTAP = new LinkLabel();
            checkboxKMLI = new CheckBox();
            linklabelFP = new LinkLabel();
            buttonSU = new Button();
            labelP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            SuspendLayout();
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImage = Properties.Resources.LoginBG;
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Location = new Point(0, -1);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1266, 1143);
            pictureBG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBG.TabIndex = 0;
            pictureBG.TabStop = false;
            // 
            // labelSI
            // 
            labelSI.AutoSize = true;
            labelSI.BackColor = Color.Transparent;
            labelSI.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelSI.ForeColor = SystemColors.ButtonHighlight;
            labelSI.Location = new Point(804, 159);
            labelSI.Name = "labelSI";
            labelSI.Size = new Size(196, 68);
            labelSI.TabIndex = 11;
            labelSI.Text = "Sign In";
            // 
            // labelAU
            // 
            labelAU.AutoSize = true;
            labelAU.BackColor = Color.Transparent;
            labelAU.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold);
            labelAU.ForeColor = SystemColors.ControlText;
            labelAU.Location = new Point(271, 159);
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
            labelInfo.Location = new Point(245, 246);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(317, 279);
            labelInfo.TabIndex = 11;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // textboxEmail
            // 
            textboxEmail.Font = new Font("Segoe UI", 14F);
            textboxEmail.Location = new Point(712, 308);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(383, 39);
            textboxEmail.TabIndex = 12;
            // 
            // textboxPassword
            // 
            textboxPassword.Font = new Font("Segoe UI", 14F);
            textboxPassword.Location = new Point(712, 424);
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
            labelE.Location = new Point(712, 274);
            labelE.Name = "labelE";
            labelE.Size = new Size(70, 31);
            labelE.TabIndex = 11;
            labelE.Text = "Email";
            // 
            // labelO
            // 
            labelO.AutoSize = true;
            labelO.BackColor = Color.Transparent;
            labelO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelO.ForeColor = SystemColors.ButtonHighlight;
            labelO.Location = new Point(887, 557);
            labelO.Name = "labelO";
            labelO.Size = new Size(40, 31);
            labelO.TabIndex = 11;
            labelO.Text = "Or";
            // 
            // buttonSI
            // 
            buttonSI.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSI.Location = new Point(743, 548);
            buttonSI.Name = "buttonSI";
            buttonSI.Size = new Size(128, 48);
            buttonSI.TabIndex = 13;
            buttonSI.Text = "Sign In";
            buttonSI.UseVisualStyleBackColor = true;
            // 
            // linklabelRM
            // 
            linklabelRM.AutoSize = true;
            linklabelRM.Font = new Font("Segoe UI", 10F);
            linklabelRM.LinkColor = Color.Black;
            linklabelRM.Location = new Point(354, 585);
            linklabelRM.Name = "linklabelRM";
            linklabelRM.Size = new Size(93, 23);
            linklabelRM.TabIndex = 14;
            linklabelRM.TabStop = true;
            linklabelRM.Text = "Read More";
            // 
            // linklabelTAP
            // 
            linklabelTAP.AutoSize = true;
            linklabelTAP.Font = new Font("Segoe UI", 10F);
            linklabelTAP.LinkColor = Color.White;
            linklabelTAP.Location = new Point(833, 611);
            linklabelTAP.Name = "linklabelTAP";
            linklabelTAP.Size = new Size(148, 23);
            linklabelTAP.TabIndex = 14;
            linklabelTAP.TabStop = true;
            linklabelTAP.Text = "Terms and Policies";
            // 
            // checkboxKMLI
            // 
            checkboxKMLI.AutoSize = true;
            checkboxKMLI.BackColor = Color.Transparent;
            checkboxKMLI.ForeColor = SystemColors.ButtonHighlight;
            checkboxKMLI.Location = new Point(712, 469);
            checkboxKMLI.Name = "checkboxKMLI";
            checkboxKMLI.Size = new Size(158, 24);
            checkboxKMLI.TabIndex = 15;
            checkboxKMLI.Text = "Keep me logged in";
            checkboxKMLI.UseVisualStyleBackColor = false;
            // 
            // linklabelFP
            // 
            linklabelFP.AutoSize = true;
            linklabelFP.Font = new Font("Segoe UI", 9F);
            linklabelFP.LinkColor = Color.White;
            linklabelFP.Location = new Point(975, 470);
            linklabelFP.Name = "linklabelFP";
            linklabelFP.Size = new Size(120, 20);
            linklabelFP.TabIndex = 14;
            linklabelFP.TabStop = true;
            linklabelFP.Text = "Forgot password";
            // 
            // buttonSU
            // 
            buttonSU.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSU.Location = new Point(941, 548);
            buttonSU.Name = "buttonSU";
            buttonSU.Size = new Size(133, 48);
            buttonSU.TabIndex = 13;
            buttonSU.Text = "Sign Up";
            buttonSU.UseVisualStyleBackColor = true;
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = Color.Transparent;
            labelP.Font = new Font("Segoe UI", 13.8F);
            labelP.ForeColor = SystemColors.ButtonHighlight;
            labelP.Location = new Point(712, 390);
            labelP.Name = "labelP";
            labelP.Size = new Size(110, 31);
            labelP.TabIndex = 11;
            labelP.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(linklabelTAP);
            Controls.Add(checkboxKMLI);
            Controls.Add(linklabelFP);
            Controls.Add(linklabelRM);
            Controls.Add(buttonSU);
            Controls.Add(buttonSI);
            Controls.Add(textboxPassword);
            Controls.Add(textboxEmail);
            Controls.Add(labelP);
            Controls.Add(labelO);
            Controls.Add(labelE);
            Controls.Add(labelInfo);
            Controls.Add(labelAU);
            Controls.Add(labelSI);
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
        private Label labelSI;
        private Label labelAU;
        private Label labelInfo;
        private TextBox textboxEmail;
        private TextBox textboxPassword;
        private Label labelE;
        private Label labelO;
        private Button buttonSI;
        private LinkLabel linklabelRM;
        private LinkLabel linklabelTAP;
        private CheckBox checkboxKMLI;
        private LinkLabel linklabelFP;
        private Button buttonSU;
        private Label labelP;
    }
}