namespace UI
{
    partial class MainWindow
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
            pictureBox1 = new PictureBox();
            buttonHome = new Button();
            buttonAbout = new Button();
            buttonProduct = new Button();
            buttonFeedback = new Button();
            buttonCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 15F);
            buttonHome.Location = new Point(690, 59);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(128, 51);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Segoe UI", 15F);
            buttonAbout.Location = new Point(829, 59);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(126, 51);
            buttonAbout.TabIndex = 1;
            buttonAbout.Text = "About";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonProduct
            // 
            buttonProduct.Font = new Font("Segoe UI", 15F);
            buttonProduct.Location = new Point(966, 59);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(126, 51);
            buttonProduct.TabIndex = 1;
            buttonProduct.Text = "Product";
            buttonProduct.UseVisualStyleBackColor = true;
            // 
            // buttonFeedback
            // 
            buttonFeedback.Font = new Font("Segoe UI", 15F);
            buttonFeedback.Location = new Point(1103, 59);
            buttonFeedback.Name = "buttonFeedback";
            buttonFeedback.Size = new Size(142, 51);
            buttonFeedback.TabIndex = 1;
            buttonFeedback.Text = "Feedback";
            buttonFeedback.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            buttonCart.Font = new Font("Segoe UI", 15F);
            buttonCart.Image = TestWindow.Properties.Resources.Cart;
            buttonCart.Location = new Point(1265, 59);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(56, 51);
            buttonCart.TabIndex = 1;
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 887);
            Controls.Add(buttonCart);
            Controls.Add(buttonFeedback);
            Controls.Add(buttonProduct);
            Controls.Add(buttonAbout);
            Controls.Add(buttonHome);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonHome;
        private Button buttonAbout;
        private Button buttonProduct;
        private Button buttonFeedback;
        private Button buttonCart;
    }
}