namespace UI
{
    partial class MyCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCart));
            buttonHome = new Button();
            buttonAbout = new Button();
            buttonCart = new Button();
            buttonFAQ = new Button();
            buttonAccount = new Button();
            buttonProducts = new Button();
            pictureBG = new PictureBox();
            labelMC = new Label();
            buttonDelete = new Button();
            checkboxSA = new CheckBox();
            checkboxSelect = new CheckBox();
            labelName = new Label();
            pictureboxImage = new PictureBox();
            labelCategory = new Label();
            labelPrice = new Label();
            buttonMinus = new Button();
            buttonAdd = new Button();
            textboxAmount = new TextBox();
            labelSO = new Label();
            labelTotal = new Label();
            labelTP = new Label();
            buttonPurchase = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxImage).BeginInit();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonHome.BackColor = Color.Transparent;
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.FlatStyle = FlatStyle.System;
            buttonHome.Font = new Font("Segoe UI", 15F);
            buttonHome.Location = new Point(453, 34);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(121, 51);
            buttonHome.TabIndex = 14;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Segoe UI", 15F);
            buttonAbout.Location = new Point(596, 34);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(119, 51);
            buttonAbout.TabIndex = 13;
            buttonAbout.Text = "About";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            buttonCart.Font = new Font("Segoe UI", 15F);
            buttonCart.Image = (Image)resources.GetObject("buttonCart.Image");
            buttonCart.Location = new Point(1178, 34);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(49, 51);
            buttonCart.TabIndex = 9;
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // buttonFAQ
            // 
            buttonFAQ.Font = new Font("Segoe UI", 15F);
            buttonFAQ.Location = new Point(877, 34);
            buttonFAQ.Name = "buttonFAQ";
            buttonFAQ.Size = new Size(125, 51);
            buttonFAQ.TabIndex = 10;
            buttonFAQ.Text = "FAQ";
            buttonFAQ.UseVisualStyleBackColor = true;
            // 
            // buttonAccount
            // 
            buttonAccount.Font = new Font("Segoe UI", 15F);
            buttonAccount.Location = new Point(1027, 34);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(119, 51);
            buttonAccount.TabIndex = 11;
            buttonAccount.Text = "Account";
            buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonProducts
            // 
            buttonProducts.Font = new Font("Segoe UI", 15F);
            buttonProducts.Location = new Point(732, 34);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(129, 51);
            buttonProducts.TabIndex = 12;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            // 
            // pictureBG
            // 
            pictureBG.Anchor = AnchorStyles.None;
            pictureBG.BackgroundImage = Properties.Resources.MyCartBG1;
            pictureBG.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBG.Location = new Point(0, -5);
            pictureBG.Name = "pictureBG";
            pictureBG.Size = new Size(1262, 1278);
            pictureBG.TabIndex = 8;
            pictureBG.TabStop = false;
            // 
            // labelMC
            // 
            labelMC.AutoSize = true;
            labelMC.BackColor = Color.Transparent;
            labelMC.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMC.ForeColor = SystemColors.ControlText;
            labelMC.Location = new Point(120, 149);
            labelMC.Name = "labelMC";
            labelMC.Size = new Size(248, 67);
            labelMC.TabIndex = 15;
            labelMC.Text = "MY CART";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ActiveCaptionText;
            buttonDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(391, 251);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 52);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // checkboxSA
            // 
            checkboxSA.AutoSize = true;
            checkboxSA.Font = new Font("Segoe UI", 10F);
            checkboxSA.Location = new Point(120, 269);
            checkboxSA.Name = "checkboxSA";
            checkboxSA.Size = new Size(99, 27);
            checkboxSA.TabIndex = 17;
            checkboxSA.Text = "Select all";
            checkboxSA.UseVisualStyleBackColor = true;
            // 
            // checkboxSelect
            // 
            checkboxSelect.AutoSize = true;
            checkboxSelect.Font = new Font("Segoe UI", 10F);
            checkboxSelect.Location = new Point(120, 389);
            checkboxSelect.Name = "checkboxSelect";
            checkboxSelect.Size = new Size(18, 17);
            checkboxSelect.TabIndex = 17;
            checkboxSelect.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(273, 424);
            labelName.Name = "labelName";
            labelName.Size = new Size(97, 23);
            labelName.TabIndex = 18;
            labelName.Text = "Name Here";
            // 
            // pictureboxImage
            // 
            pictureboxImage.BackgroundImage = Properties.Resources.Homepic2;
            pictureboxImage.Location = new Point(144, 389);
            pictureboxImage.Name = "pictureboxImage";
            pictureboxImage.Size = new Size(114, 108);
            pictureboxImage.TabIndex = 19;
            pictureboxImage.TabStop = false;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(273, 389);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(120, 23);
            labelCategory.TabIndex = 18;
            labelCategory.Text = "Category Here";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            labelPrice.Location = new Point(273, 461);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(139, 36);
            labelPrice.TabIndex = 18;
            labelPrice.Text = "Price Here";
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(669, 460);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(46, 37);
            buttonMinus.TabIndex = 16;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(774, 460);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(46, 37);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textboxAmount
            // 
            textboxAmount.Font = new Font("Segoe UI", 13.4F);
            textboxAmount.Location = new Point(721, 460);
            textboxAmount.Name = "textboxAmount";
            textboxAmount.Size = new Size(47, 37);
            textboxAmount.TabIndex = 20;
            // 
            // labelSO
            // 
            labelSO.AutoSize = true;
            labelSO.BackColor = Color.Transparent;
            labelSO.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelSO.ForeColor = SystemColors.ControlText;
            labelSO.Location = new Point(959, 251);
            labelSO.Name = "labelSO";
            labelSO.Size = new Size(202, 35);
            labelSO.TabIndex = 15;
            labelSO.Text = "Summary Order";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.ControlText;
            labelTotal.Location = new Point(959, 315);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 23);
            labelTotal.TabIndex = 15;
            labelTotal.Text = "Total:";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.BackColor = Color.Transparent;
            labelTP.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelTP.ForeColor = SystemColors.ControlText;
            labelTP.Location = new Point(1028, 305);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(131, 35);
            labelTP.TabIndex = 15;
            labelTP.Text = "TotalPrice";
            // 
            // buttonPurchase
            // 
            buttonPurchase.BackColor = SystemColors.ActiveCaptionText;
            buttonPurchase.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonPurchase.ForeColor = SystemColors.ButtonHighlight;
            buttonPurchase.Location = new Point(1022, 354);
            buttonPurchase.Name = "buttonPurchase";
            buttonPurchase.Size = new Size(137, 52);
            buttonPurchase.TabIndex = 16;
            buttonPurchase.Text = "Purchase";
            buttonPurchase.UseVisualStyleBackColor = false;
            // 
            // MyCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 753);
            Controls.Add(textboxAmount);
            Controls.Add(pictureboxImage);
            Controls.Add(labelCategory);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(checkboxSelect);
            Controls.Add(checkboxSA);
            Controls.Add(buttonAdd);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPurchase);
            Controls.Add(buttonDelete);
            Controls.Add(labelTotal);
            Controls.Add(labelTP);
            Controls.Add(labelSO);
            Controls.Add(labelMC);
            Controls.Add(buttonHome);
            Controls.Add(buttonAbout);
            Controls.Add(buttonCart);
            Controls.Add(buttonFAQ);
            Controls.Add(buttonAccount);
            Controls.Add(buttonProducts);
            Controls.Add(pictureBG);
            Name = "MyCart";
            Text = "MyCart";
            Load += MyCart_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHome;
        private Button buttonAbout;
        private Button buttonCart;
        private Button buttonFAQ;
        private Button buttonAccount;
        private Button buttonProducts;
        private PictureBox pictureBG;
        private Label labelMC;
        private Button buttonDelete;
        private CheckBox checkboxSA;
        private CheckBox checkboxSelect;
        internal Label labelName;
        private PictureBox pictureboxImage;
        internal Label labelCategory;
        internal Label labelPrice;
        private Button buttonMinus;
        private Button buttonAdd;
        private TextBox textboxAmount;
        private Label labelSO;
        private Label labelTotal;
        private Label labelTP;
        private Button buttonPurchase;
    }
}