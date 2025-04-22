namespace UI
{
    partial class EmailResetPasswordWindow
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
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.previous_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(295, 482);
            button2.Name = "button2";
            button2.Size = new Size(163, 38);
            button2.TabIndex = 45;
            button2.Text = "Back to Login";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 242);
            label2.Name = "label2";
            label2.Size = new Size(391, 21);
            label2.TabIndex = 44;
            label2.Text = "Enter your email so that we can send your reset passcode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 298);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 43;
            label1.Text = "Enter your email";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(205, 331);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(350, 39);
            textBox5.TabIndex = 42;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(205, 408);
            button1.Name = "button1";
            button1.Size = new Size(350, 38);
            button1.TabIndex = 41;
            button1.Text = "Send Email";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmailResetPasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            ClientSize = new Size(751, 761);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Name = "EmailResetPasswordWindow";
            Text = "EmailResetPasswordWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private Button button1;
    }
}