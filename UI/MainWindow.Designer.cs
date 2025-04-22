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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            buttonCart = new Button();
            buttonFAQ = new Button();
            buttonProducts = new Button();
            buttonAbout = new Button();
            buttonHome = new Button();
            pictureBG = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelSP2 = new Label();
            pictureBox1 = new PictureBox();
            labelSP1 = new Label();
            buttonAccount = new Button();
            labelTitle = new Label();
            labelFooter = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonCart
            // 
            buttonCart.Font = new Font("Segoe UI", 15F);
            buttonCart.Image = (Image)resources.GetObject("buttonCart.Image");
            buttonCart.Location = new Point(1139, 28);
            buttonCart.Margin = new Padding(3, 2, 3, 2);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(43, 38);
            buttonCart.TabIndex = 3;
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // buttonFAQ
            // 
            buttonFAQ.Font = new Font("Segoe UI", 15F);
            buttonFAQ.Location = new Point(881, 28);
            buttonFAQ.Margin = new Padding(3, 2, 3, 2);
            buttonFAQ.Name = "buttonFAQ";
            buttonFAQ.Size = new Size(109, 38);
            buttonFAQ.TabIndex = 4;
            buttonFAQ.Text = "FAQ";
            buttonFAQ.UseVisualStyleBackColor = true;
            // 
            // buttonProducts
            // 
            buttonProducts.Font = new Font("Segoe UI", 15F);
            buttonProducts.Location = new Point(749, 28);
            buttonProducts.Margin = new Padding(3, 2, 3, 2);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(113, 38);
            buttonProducts.TabIndex = 5;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Segoe UI", 15F);
            buttonAbout.Location = new Point(630, 28);
            buttonAbout.Margin = new Padding(3, 2, 3, 2);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(104, 38);
            buttonAbout.TabIndex = 6;
            buttonAbout.Text = "About";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Transparent;
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.FlatStyle = FlatStyle.System;
            buttonHome.Font = new Font("Segoe UI", 15F);
            buttonHome.Location = new Point(505, 28);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(106, 38);
            buttonHome.TabIndex = 7;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImage = (Image)resources.GetObject("pictureBG.BackgroundImage");
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Location = new Point(-2, -4);
            pictureBG.Margin = new Padding(3, 2, 3, 2);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1208, 1055);
            pictureBG.TabIndex = 2;
            pictureBG.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(42, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.Homepic2;
            pictureBox4.Location = new Point(779, 259);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(373, 232);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // labelSP2
            // 
            labelSP2.AutoSize = true;
            labelSP2.BackColor = Color.Transparent;
            labelSP2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSP2.ForeColor = SystemColors.ButtonHighlight;
            labelSP2.Location = new Point(830, 222);
            labelSP2.Name = "labelSP2";
            labelSP2.Size = new Size(256, 37);
            labelSP2.TabIndex = 10;
            labelSP2.Text = "Modern Collection";
            labelSP2.Click += labelSP2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainWinSale;
            pictureBox1.Location = new Point(1, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 588);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelSP1
            // 
            labelSP1.AutoSize = true;
            labelSP1.BackColor = Color.Transparent;
            labelSP1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSP1.ForeColor = SystemColors.ButtonHighlight;
            labelSP1.Location = new Point(306, 222);
            labelSP1.Name = "labelSP1";
            labelSP1.Size = new Size(262, 37);
            labelSP1.TabIndex = 10;
            labelSP1.Text = "Wooden Collection";
            labelSP1.Click += labelSP2_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Font = new Font("Segoe UI", 15F);
            buttonAccount.Location = new Point(1007, 28);
            buttonAccount.Margin = new Padding(3, 2, 3, 2);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(104, 38);
            buttonAccount.TabIndex = 5;
            buttonAccount.Text = "Account";
            buttonAccount.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(381, 105);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(573, 72);
            labelTitle.TabIndex = 10;
            labelTitle.Text = "Welcome to our shop";
            labelTitle.Click += labelSP2_Click;
            // 
            // labelFooter
            // 
            labelFooter.AutoSize = true;
            labelFooter.BackColor = Color.Transparent;
            labelFooter.Font = new Font("Segoe UI Semilight", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFooter.ForeColor = SystemColors.ButtonHighlight;
            labelFooter.Location = new Point(505, 611);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(392, 28);
            labelFooter.TabIndex = 10;
            labelFooter.Text = "Hope you have the best shopping experience";
            labelFooter.Click += labelSP2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.Homepic1;
            pictureBox3.Location = new Point(248, 259);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(391, 232);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 665);
            Controls.Add(pictureBox1);
            Controls.Add(labelSP1);
            Controls.Add(labelFooter);
            Controls.Add(labelTitle);
            Controls.Add(labelSP2);
            Controls.Add(buttonHome);
            Controls.Add(pictureBox2);
            Controls.Add(buttonAbout);
            Controls.Add(buttonCart);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(buttonFAQ);
            Controls.Add(buttonAccount);
            Controls.Add(buttonProducts);
            Controls.Add(pictureBG);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            Text = "Main Window";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCart;
        private Button buttonFAQ;
        private Button buttonProducts;
        private Button buttonAbout;
        private Button buttonHome;
        private PictureBox pictureBG;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label labelSP2;
        private PictureBox pictureBox1;
        private Label labelSP1;
        private Button buttonAccount;
        private Label labelTitle;
        private Label labelFooter;
        private PictureBox pictureBox3;
    }
}