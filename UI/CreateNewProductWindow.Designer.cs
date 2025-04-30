namespace UI
{
    partial class CreateNewProductWindow
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
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxWarranty = new TextBox();
            textBoxProductID = new TextBox();
            textBoxType = new TextBox();
            buttonCreate = new Button();
            buttonExit = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(335, 205);
            textBoxProductName.Multiline = true;
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(345, 35);
            textBoxProductName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(335, 272);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(345, 35);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(335, 339);
            textBoxQuantity.Multiline = true;
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(345, 35);
            textBoxQuantity.TabIndex = 2;
            // 
            // textBoxWarranty
            // 
            textBoxWarranty.Location = new Point(335, 475);
            textBoxWarranty.Multiline = true;
            textBoxWarranty.Name = "textBoxWarranty";
            textBoxWarranty.Size = new Size(345, 35);
            textBoxWarranty.TabIndex = 3;
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(335, 139);
            textBoxProductID.Multiline = true;
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(345, 35);
            textBoxProductID.TabIndex = 4;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(335, 409);
            textBoxType.Multiline = true;
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(345, 35);
            textBoxType.TabIndex = 5;
            textBoxType.TextChanged += textBox6_TextChanged;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.ButtonShadow;
            buttonCreate.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreate.ForeColor = SystemColors.HighlightText;
            buttonCreate.Location = new Point(115, 539);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(154, 55);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ButtonShadow;
            buttonExit.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = SystemColors.HighlightText;
            buttonExit.Location = new Point(526, 539);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(154, 55);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += button1_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ButtonShadow;
            buttonUpdate.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = SystemColors.HighlightText;
            buttonUpdate.Location = new Point(320, 539);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(154, 55);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // CreateNewProductWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(805, 653);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxType);
            Controls.Add(textBoxProductID);
            Controls.Add(textBoxWarranty);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Name = "CreateNewProductWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewProductWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private TextBox textBoxWarranty;
        private TextBox textBoxProductID;
        private TextBox textBoxType;
        private Button buttonCreate;
        private Button buttonExit;
        private Button buttonUpdate;
    }
}