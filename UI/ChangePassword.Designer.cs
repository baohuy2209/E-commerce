namespace UI
{
    partial class ChangePassword
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
            pictureBG = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            SuspendLayout();
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImage = Properties.Resources.ChangePassBG3;
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Dock = DockStyle.Fill;
            pictureBG.Location = new Point(0, 0);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1262, 753);
            pictureBG.TabIndex = 16;
            pictureBG.TabStop = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(pictureBG);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBG;
    }
}