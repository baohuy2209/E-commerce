namespace UI
{
    partial class ResetPasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordWindow));
            button2 = new Button();
            buttonChangePassword = new Button();
            label1 = new Label();
            textBoxNewPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.previous_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(270, 476);
            button2.Name = "button2";
            button2.Size = new Size(60, 38);
            button2.TabIndex = 60;
            button2.UseVisualStyleBackColor = false;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = SystemColors.ActiveCaptionText;
            buttonChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangePassword.ForeColor = SystemColors.ButtonHighlight;
            buttonChangePassword.Location = new Point(374, 351);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(214, 38);
            buttonChangePassword.TabIndex = 57;
            buttonChangePassword.Text = "Get passcode";
            buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 255);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 56;
            label1.Text = "Enter your email";
            label1.Click += label1_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(295, 289);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(376, 39);
            textBoxNewPassword.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 182);
            label2.Name = "label2";
            label2.Size = new Size(371, 21);
            label2.TabIndex = 61;
            label2.Text = "Please kindly type your email to get passcode via email";
            // 
            // ResetPasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 598);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(buttonChangePassword);
            Controls.Add(label1);
            Controls.Add(textBoxNewPassword);
            Name = "ResetPasswordWindow";
            Text = "ResetPasswordWindow";
            Load += ResetPasswordWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button buttonChangePassword;
        private Label label1;
        private TextBox textBoxNewPassword;
        private Label label2;
    }
}