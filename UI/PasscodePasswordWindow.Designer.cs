namespace UI
{
    partial class PasscodePasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasscodePasswordWindow));
            buttonChangePassword = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxNewPassword = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = SystemColors.ActiveCaptionText;
            buttonChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangePassword.ForeColor = SystemColors.ButtonHighlight;
            buttonChangePassword.Location = new Point(373, 338);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(214, 38);
            buttonChangePassword.TabIndex = 52;
            buttonChangePassword.Text = "Submit";
            buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(342, 183);
            label2.Name = "label2";
            label2.Size = new Size(273, 21);
            label2.TabIndex = 51;
            label2.Text = "Enter your passcode that send via email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 242);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 50;
            label1.Text = "Passcode";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(293, 276);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(376, 39);
            textBoxNewPassword.TabIndex = 49;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.previous_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(256, 479);
            button2.Name = "button2";
            button2.Size = new Size(60, 38);
            button2.TabIndex = 53;
            button2.UseVisualStyleBackColor = false;
            // 
            // PasscodePasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 600);
            Controls.Add(button2);
            Controls.Add(buttonChangePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNewPassword);
            Name = "PasscodePasswordWindow";
            Text = "PasscodePasswordWindow";
            Load += PasscodePasswordWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonChangePassword;
        private Label label2;
        private Label label1;
        private TextBox textBoxNewPassword;
        private Button button2;
    }
}