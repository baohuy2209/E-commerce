namespace UI
{
    partial class MembershipManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipManagement));
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Table_Membership = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            contextMenuStripMembership = new ContextMenuStrip(components);
            Update_ContextMnuStrip = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            DeleteContextMnuStrip = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)Table_Membership).BeginInit();
            contextMenuStripMembership.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Gill Sans MT", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = SystemColors.ControlLightLight;
            guna2HtmlLabel5.Location = new Point(523, 118);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(1099, 85);
            guna2HtmlLabel5.TabIndex = 3;
            guna2HtmlLabel5.Text = "MEMBERSHIP CARD MANAGEMENT";
            // 
            // Table_Membership
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Table_Membership.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Table_Membership.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Tan;
            dataGridViewCellStyle2.Font = new Font("#9Slide03 Arima Madurai Medium", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Table_Membership.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Table_Membership.ColumnHeadersHeight = 112;
            Table_Membership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table_Membership.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            Table_Membership.ContextMenuStrip = contextMenuStripMembership;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Table_Membership.DefaultCellStyle = dataGridViewCellStyle3;
            Table_Membership.GridColor = Color.Black;
            Table_Membership.Location = new Point(304, 305);
            Table_Membership.Name = "Table_Membership";
            Table_Membership.RowHeadersVisible = false;
            Table_Membership.RowHeadersWidth = 92;
            Table_Membership.Size = new Size(1392, 857);
            Table_Membership.TabIndex = 4;
            Table_Membership.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Table_Membership.ThemeStyle.AlternatingRowsStyle.Font = null;
            Table_Membership.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Table_Membership.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Table_Membership.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Table_Membership.ThemeStyle.BackColor = Color.WhiteSmoke;
            Table_Membership.ThemeStyle.GridColor = Color.Black;
            Table_Membership.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Table_Membership.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Table_Membership.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Table_Membership.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Table_Membership.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table_Membership.ThemeStyle.HeaderStyle.Height = 112;
            Table_Membership.ThemeStyle.ReadOnly = false;
            Table_Membership.ThemeStyle.RowsStyle.BackColor = Color.White;
            Table_Membership.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Table_Membership.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Table_Membership.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Table_Membership.ThemeStyle.RowsStyle.Height = 45;
            Table_Membership.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Table_Membership.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.MinimumWidth = 11;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Membership ID";
            Column2.MinimumWidth = 11;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Customer ID";
            Column3.MinimumWidth = 11;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Rank";
            Column4.MinimumWidth = 11;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Point";
            Column5.MinimumWidth = 11;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Created Date";
            Column6.MinimumWidth = 11;
            Column6.Name = "Column6";
            // 
            // contextMenuStripMembership
            // 
            contextMenuStripMembership.ImageScalingSize = new Size(36, 36);
            contextMenuStripMembership.Items.AddRange(new ToolStripItem[] { Update_ContextMnuStrip, toolStripMenuItem1, DeleteContextMnuStrip, toolStripMenuItem2 });
            contextMenuStripMembership.Name = "contextMenuStripMembership";
            contextMenuStripMembership.Size = new Size(565, 120);
            contextMenuStripMembership.Opening += contextMenuStripMembership_Opening;
            // 
            // Update_ContextMnuStrip
            // 
            Update_ContextMnuStrip.BackColor = Color.Tan;
            Update_ContextMnuStrip.Font = new Font("#9Slide03 Arima Madurai Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_ContextMnuStrip.Image = (Image)resources.GetObject("Update_ContextMnuStrip.Image");
            Update_ContextMnuStrip.Name = "Update_ContextMnuStrip";
            Update_ContextMnuStrip.Size = new Size(564, 52);
            Update_ContextMnuStrip.Text = "Update Selected Membership Card";
            Update_ContextMnuStrip.Click += cToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(561, 6);
            // 
            // DeleteContextMnuStrip
            // 
            DeleteContextMnuStrip.BackColor = Color.Tan;
            DeleteContextMnuStrip.Font = new Font("#9Slide03 Arima Madurai Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteContextMnuStrip.Image = (Image)resources.GetObject("DeleteContextMnuStrip.Image");
            DeleteContextMnuStrip.Name = "DeleteContextMnuStrip";
            DeleteContextMnuStrip.Size = new Size(564, 52);
            DeleteContextMnuStrip.Text = "Delete Selected Membership Card";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(561, 6);
            // 
            // MembershipManagement
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2000, 1266);
            Controls.Add(Table_Membership);
            Controls.Add(guna2HtmlLabel5);
            DoubleBuffered = true;
            Name = "MembershipManagement";
            Text = "MembershipManagement";
            ((System.ComponentModel.ISupportInitialize)Table_Membership).EndInit();
            contextMenuStripMembership.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DataGridView Table_Membership;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ContextMenuStrip contextMenuStripMembership;
        private ToolStripMenuItem Update_ContextMnuStrip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem DeleteContextMnuStrip;
        private ToolStripSeparator toolStripMenuItem2;
    }
}