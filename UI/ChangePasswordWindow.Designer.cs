namespace UI
{
    partial class ChangePasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordWindow));
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Button();
            textBox1 = new TextBox();
            roundedBox2 = new RoundedBox();
            label1 = new Label();
            textBox2 = new TextBox();
            roundedBox1 = new RoundedBox();
            label2 = new Label();
            SuspendLayout();
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
            guna2Button1.Location = new Point(384, 408);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(196, 45);
            guna2Button1.TabIndex = 73;
            guna2Button1.Text = "Change password";
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
            button2.Location = new Point(449, 476);
            button2.Name = "button2";
            button2.Size = new Size(60, 38);
            button2.TabIndex = 72;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(290, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 42);
            textBox1.TabIndex = 71;
            // 
            // roundedBox2
            // 
            roundedBox2.BackColor = Color.Transparent;
            roundedBox2.BorderColor = Color.Black;
            roundedBox2.BorderRadius = 15;
            roundedBox2.BorderWidth = 2;
            roundedBox2.Location = new Point(282, 223);
            roundedBox2.Margin = new Padding(3, 2, 3, 2);
            roundedBox2.Name = "roundedBox2";
            roundedBox2.Size = new Size(387, 55);
            roundedBox2.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 192);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 69;
            label1.Text = "Enter new password";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(290, 336);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 42);
            textBox2.TabIndex = 76;
            // 
            // roundedBox1
            // 
            roundedBox1.BackColor = Color.Transparent;
            roundedBox1.BorderColor = Color.Black;
            roundedBox1.BorderRadius = 15;
            roundedBox1.BorderWidth = 2;
            roundedBox1.Location = new Point(282, 329);
            roundedBox1.Margin = new Padding(3, 2, 3, 2);
            roundedBox1.Name = "roundedBox1";
            roundedBox1.Size = new Size(387, 55);
            roundedBox1.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 298);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 74;
            label2.Text = "Re-enter new password";
            // 
            // ChangePasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 598);
            Controls.Add(textBox2);
            Controls.Add(roundedBox1);
            Controls.Add(label2);
            Controls.Add(guna2Button1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(roundedBox2);
            Controls.Add(label1);
            Name = "ChangePasswordWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Button button2;
        private TextBox textBox1;
        private RoundedBox roundedBox2;
        private Label label1;
        private TextBox textBox2;
        private RoundedBox roundedBox1;
        private Label label2;
    }
}