namespace UI
{
    partial class OrderManagementWindow
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementWindow));
            Table_Order = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            convertDeliveryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            checkStockAvailabilityToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            ButtonConvert = new Guna.UI2.WinForms.Guna2GradientButton();
            ButtonCheckStock = new Guna.UI2.WinForms.Guna2GradientButton();
            menuStrip1 = new MenuStrip();
            orderManagementToolStripMenuItem = new ToolStripMenuItem();
            Create_Menu = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            Delete_Menu = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            Update_Menu = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            Exit_Menu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Table_Order).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Table_Order
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Table_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Table_Order.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Tan;
            dataGridViewCellStyle2.Font = new Font("#9Slide03 Arima Madurai Medium", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Table_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Table_Order.ColumnHeadersHeight = 112;
            Table_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table_Order.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4, Column5 });
            Table_Order.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Table_Order.DefaultCellStyle = dataGridViewCellStyle3;
            Table_Order.GridColor = Color.Black;
            Table_Order.Location = new Point(248, 357);
            Table_Order.Name = "Table_Order";
            Table_Order.RowHeadersVisible = false;
            Table_Order.RowHeadersWidth = 92;
            Table_Order.Size = new Size(1392, 657);
            Table_Order.TabIndex = 0;
            Table_Order.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Table_Order.ThemeStyle.AlternatingRowsStyle.Font = null;
            Table_Order.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Table_Order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Table_Order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Table_Order.ThemeStyle.BackColor = Color.WhiteSmoke;
            Table_Order.ThemeStyle.GridColor = Color.Black;
            Table_Order.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Table_Order.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Table_Order.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Table_Order.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Table_Order.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table_Order.ThemeStyle.HeaderStyle.Height = 112;
            Table_Order.ThemeStyle.ReadOnly = false;
            Table_Order.ThemeStyle.RowsStyle.BackColor = Color.White;
            Table_Order.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Table_Order.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Table_Order.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Table_Order.ThemeStyle.RowsStyle.Height = 45;
            Table_Order.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Table_Order.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.MinimumWidth = 11;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Order ID";
            Column2.MinimumWidth = 11;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Customer ID";
            Column3.MinimumWidth = 11;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cart ID";
            Column6.MinimumWidth = 11;
            Column6.Name = "Column6";
            // 
            // Column4
            // 
            Column4.HeaderText = "Total Amount";
            Column4.MinimumWidth = 11;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Date Created";
            Column5.MinimumWidth = 11;
            Column5.Name = "Column5";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { convertDeliveryToolStripMenuItem, toolStripMenuItem1, checkStockAvailabilityToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(385, 178);
            // 
            // convertDeliveryToolStripMenuItem
            // 
            convertDeliveryToolStripMenuItem.Font = new Font("#9Slide03 Arima Madurai", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertDeliveryToolStripMenuItem.Name = "convertDeliveryToolStripMenuItem";
            convertDeliveryToolStripMenuItem.Size = new Size(384, 52);
            convertDeliveryToolStripMenuItem.Text = "Convert Delivery";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(381, 6);
            // 
            // checkStockAvailabilityToolStripMenuItem
            // 
            checkStockAvailabilityToolStripMenuItem.Font = new Font("#9Slide03 Arima Madurai", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkStockAvailabilityToolStripMenuItem.Name = "checkStockAvailabilityToolStripMenuItem";
            checkStockAvailabilityToolStripMenuItem.Size = new Size(384, 52);
            checkStockAvailabilityToolStripMenuItem.Text = "Check Stock Availability";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(381, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("#9Slide03 Arima Madurai", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(384, 52);
            exitToolStripMenuItem.Text = "View Order Details";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(381, 6);
            // 
            // ButtonConvert
            // 
            ButtonConvert.BackColor = Color.Transparent;
            ButtonConvert.BorderRadius = 35;
            ButtonConvert.CustomizableEdges = customizableEdges1;
            ButtonConvert.DisabledState.BorderColor = Color.DarkGray;
            ButtonConvert.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonConvert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonConvert.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ButtonConvert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonConvert.FillColor = Color.Tan;
            ButtonConvert.FillColor2 = Color.BurlyWood;
            ButtonConvert.FocusedColor = Color.Transparent;
            ButtonConvert.Font = new Font("#9Slide03 Arima Madurai Medium", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConvert.ForeColor = Color.White;
            ButtonConvert.Location = new Point(479, 1082);
            ButtonConvert.Name = "ButtonConvert";
            ButtonConvert.PressedColor = Color.Transparent;
            ButtonConvert.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonConvert.Size = new Size(376, 79);
            ButtonConvert.TabIndex = 2;
            ButtonConvert.Text = "Convert Delivery";
            // 
            // ButtonCheckStock
            // 
            ButtonCheckStock.BackColor = Color.Transparent;
            ButtonCheckStock.BorderRadius = 35;
            ButtonCheckStock.CustomizableEdges = customizableEdges3;
            ButtonCheckStock.DisabledState.BorderColor = Color.DarkGray;
            ButtonCheckStock.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonCheckStock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonCheckStock.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ButtonCheckStock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonCheckStock.FillColor = Color.Tan;
            ButtonCheckStock.FillColor2 = Color.BurlyWood;
            ButtonCheckStock.FocusedColor = Color.Transparent;
            ButtonCheckStock.Font = new Font("#9Slide03 Arima Madurai Medium", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCheckStock.ForeColor = Color.White;
            ButtonCheckStock.Location = new Point(935, 1082);
            ButtonCheckStock.Name = "ButtonCheckStock";
            ButtonCheckStock.PressedColor = Color.Transparent;
            ButtonCheckStock.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ButtonCheckStock.Size = new Size(501, 79);
            ButtonCheckStock.TabIndex = 3;
            ButtonCheckStock.Text = "Check Stock Availability";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Tan;
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1912, 58);
            menuStrip1.TabIndex = 4;
            menuStrip1.TabStop = true;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderManagementToolStripMenuItem
            // 
            orderManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Create_Menu, toolStripMenuItem4, Delete_Menu, toolStripMenuItem5, Update_Menu, toolStripMenuItem6, Exit_Menu });
            orderManagementToolStripMenuItem.Font = new Font("#9Slide03 Arima Madurai ExtraBo", 9.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderManagementToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            orderManagementToolStripMenuItem.Size = new Size(311, 54);
            orderManagementToolStripMenuItem.Text = "Order Management";
            // 
            // Create_Menu
            // 
            Create_Menu.BackColor = Color.Tan;
            Create_Menu.BackgroundImageLayout = ImageLayout.None;
            Create_Menu.ForeColor = SystemColors.ButtonFace;
            Create_Menu.Image = (Image)resources.GetObject("Create_Menu.Image");
            Create_Menu.Name = "Create_Menu";
            Create_Menu.Size = new Size(488, 58);
            Create_Menu.Text = "Create New Order";
            Create_Menu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(485, 6);
            // 
            // Delete_Menu
            // 
            Delete_Menu.BackColor = Color.Tan;
            Delete_Menu.ForeColor = SystemColors.ButtonFace;
            Delete_Menu.Image = (Image)resources.GetObject("Delete_Menu.Image");
            Delete_Menu.Name = "Delete_Menu";
            Delete_Menu.Size = new Size(488, 58);
            Delete_Menu.Text = "Delete Selected Order";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(485, 6);
            // 
            // Update_Menu
            // 
            Update_Menu.BackColor = Color.Tan;
            Update_Menu.ForeColor = SystemColors.ButtonFace;
            Update_Menu.Image = (Image)resources.GetObject("Update_Menu.Image");
            Update_Menu.Name = "Update_Menu";
            Update_Menu.Size = new Size(488, 58);
            Update_Menu.Text = "Update Selected Order";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(485, 6);
            // 
            // Exit_Menu
            // 
            Exit_Menu.BackColor = Color.Tan;
            Exit_Menu.ForeColor = SystemColors.ButtonFace;
            Exit_Menu.Image = (Image)resources.GetObject("Exit_Menu.Image");
            Exit_Menu.Name = "Exit_Menu";
            Exit_Menu.Size = new Size(488, 58);
            Exit_Menu.Text = "Exit";
            // 
            // OrderManagementWindow
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1912, 1225);
            Controls.Add(ButtonCheckStock);
            Controls.Add(menuStrip1);
            Controls.Add(ButtonConvert);
            Controls.Add(Table_Order);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "OrderManagementWindow";
            Text = "OrderManagementWindow";
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)Table_Order).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Table_Order;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem convertDeliveryToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem checkStockAvailabilityToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonConvert;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonCheckStock;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem orderManagementToolStripMenuItem;
        private ToolStripMenuItem Create_Menu;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem Delete_Menu;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem Update_Menu;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem Exit_Menu;
    }
}