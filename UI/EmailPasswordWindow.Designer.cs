namespace UI
{
    partial class EmailPasswordWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailPasswordWindow));
            label2 = new Label();
            textBoxNewPassword = new TextBox();
            roundedBox1 = new RoundedBox();
            label1 = new Label();
            button2 = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
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
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(295, 289);
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(372, 42);
            textBoxNewPassword.TabIndex = 62;
            // 
            // roundedBox1
            // 
            roundedBox1.BackColor = Color.Transparent;
            roundedBox1.BorderColor = Color.Black;
            roundedBox1.BorderRadius = 15;
            roundedBox1.BorderWidth = 2;
            roundedBox1.Location = new Point(286, 283);
            roundedBox1.Margin = new Padding(3, 2, 3, 2);
            roundedBox1.Name = "roundedBox1";
            roundedBox1.Size = new Size(387, 55);
            roundedBox1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 249);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 56;
            label1.Text = "Enter your email";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.previous_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(448, 477);
            button2.Name = "button2";
            button2.Size = new Size(60, 38);
            button2.TabIndex = 64;
            button2.UseVisualStyleBackColor = false;
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
            guna2Button1.Location = new Point(403, 360);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(154, 50);
            guna2Button1.TabIndex = 65;
            guna2Button1.Text = "Send code";
            // 
            // EmailPasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 598);
            Controls.Add(guna2Button1);
            Controls.Add(button2);
            Controls.Add(textBoxNewPassword);
            Controls.Add(roundedBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmailPasswordWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordWindow";
            Load += ResetPasswordWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBoxNewPassword;
        private RoundedBox roundedBox1;
        private Label label1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}