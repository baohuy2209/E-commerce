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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelSP2 = new Label();
            pictureBox1 = new PictureBox();
            labelSP1 = new Label();
            buttonAccount = new Button();
            labelTitle = new Label();
            labelFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCart
            // 
            buttonCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCart.Font = new Font("Segoe UI", 15F);
            buttonCart.Image = (Image)resources.GetObject("buttonCart.Image");
            buttonCart.Location = new Point(1159, 37);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(49, 51);
            buttonCart.TabIndex = 3;
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // buttonFAQ
            // 
            buttonFAQ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFAQ.Font = new Font("Segoe UI", 15F);
            buttonFAQ.Location = new Point(864, 37);
            buttonFAQ.Name = "buttonFAQ";
            buttonFAQ.Size = new Size(125, 51);
            buttonFAQ.TabIndex = 4;
            buttonFAQ.Text = "FAQ";
            buttonFAQ.UseVisualStyleBackColor = true;
            // 
            // buttonProducts
            // 
            buttonProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProducts.Font = new Font("Segoe UI", 15F);
            buttonProducts.Location = new Point(713, 37);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(129, 51);
            buttonProducts.TabIndex = 5;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout.Font = new Font("Segoe UI", 15F);
            buttonAbout.Location = new Point(577, 37);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(119, 51);
            buttonAbout.TabIndex = 6;
            buttonAbout.Text = "About";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHome.BackColor = Color.Transparent;
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.FlatStyle = FlatStyle.System;
            buttonHome.Font = new Font("Segoe UI", 15F);
            buttonHome.Location = new Point(434, 37);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(121, 51);
            buttonHome.TabIndex = 7;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // pictureBG
            // 
            pictureBG.BackgroundImage = (Image)resources.GetObject("pictureBG.BackgroundImage");
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Location = new Point(-2, -6);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1381, 1407);
            pictureBG.TabIndex = 2;
            pictureBG.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(48, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.Homepic1;
            pictureBox3.Location = new Point(283, 345);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(446, 308);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.Homepic2;
            pictureBox4.Location = new Point(800, 343);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(426, 308);
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
            labelSP2.Location = new Point(859, 294);
            labelSP2.Name = "labelSP2";
            labelSP2.Size = new Size(318, 46);
            labelSP2.TabIndex = 10;
            labelSP2.Text = "Modern Collection";
            labelSP2.Click += labelSP2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainWinSale;
            pictureBox1.Location = new Point(1, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 784);
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
            labelSP1.Location = new Point(350, 296);
            labelSP1.Name = "labelSP1";
            labelSP1.Size = new Size(325, 46);
            labelSP1.TabIndex = 10;
            labelSP1.Text = "Wooden Collection";
            labelSP1.Click += labelSP2_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAccount.Font = new Font("Segoe UI", 15F);
            buttonAccount.Location = new Point(1008, 37);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(119, 51);
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
            labelTitle.Location = new Point(366, 135);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(710, 89);
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
            labelFooter.Location = new Point(577, 815);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(487, 35);
            labelFooter.TabIndex = 10;
            labelFooter.Text = "Hope you have the best shopping experience";
            labelFooter.Click += labelSP2_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
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
            Name = "MainWindow";
            Text = "Main Window";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label labelSP2;
        private PictureBox pictureBox1;
        private Label labelSP1;
        private Button buttonAccount;
        private Label labelTitle;
        private Label labelFooter;
    }
}