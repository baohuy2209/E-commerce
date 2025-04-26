namespace UI
{
    partial class ManagerWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            tabPageManagement = new TabPage();
            tabPageDelivery = new TabPage();
            tabPageInvoice = new TabPage();
            tabPageFeedback = new TabPage();
            tabPageDiscount = new TabPage();
            guna2TabControlManagement = new Guna.UI2.WinForms.Guna2TabControl();
            guna2TabControlManagement.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.BackColor = Color.FromArgb(33, 42, 57);
            guna2GradientPanel2.CustomizableEdges = customizableEdges3;
            guna2GradientPanel2.Dock = DockStyle.Top;
            guna2GradientPanel2.Location = new Point(0, 0);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel2.Size = new Size(1264, 55);
            guna2GradientPanel2.TabIndex = 0;
            guna2GradientPanel2.Paint += guna2GradientPanel2_Paint;
            // 
            // tabPageManagement
            // 
            tabPageManagement.Location = new Point(4, 59);
            tabPageManagement.Name = "tabPageManagement";
            tabPageManagement.Size = new Size(1256, 644);
            tabPageManagement.TabIndex = 6;
            tabPageManagement.Text = "Staff management";
            tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageDelivery
            // 
            tabPageDelivery.Location = new Point(4, 59);
            tabPageDelivery.Name = "tabPageDelivery";
            tabPageDelivery.Size = new Size(1256, 644);
            tabPageDelivery.TabIndex = 5;
            tabPageDelivery.Text = "Delivery management";
            tabPageDelivery.UseVisualStyleBackColor = true;
            // 
            // tabPageInvoice
            // 
            tabPageInvoice.Location = new Point(4, 59);
            tabPageInvoice.Name = "tabPageInvoice";
            tabPageInvoice.Size = new Size(1256, 644);
            tabPageInvoice.TabIndex = 4;
            tabPageInvoice.Text = "Invoice management";
            tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // tabPageFeedback
            // 
            tabPageFeedback.Location = new Point(4, 59);
            tabPageFeedback.Name = "tabPageFeedback";
            tabPageFeedback.Size = new Size(1256, 644);
            tabPageFeedback.TabIndex = 3;
            tabPageFeedback.Text = "Feedback management";
            tabPageFeedback.UseVisualStyleBackColor = true;
            // 
            // tabPageDiscount
            // 
            tabPageDiscount.Location = new Point(4, 59);
            tabPageDiscount.Name = "tabPageDiscount";
            tabPageDiscount.Size = new Size(1256, 644);
            tabPageDiscount.TabIndex = 2;
            tabPageDiscount.Text = "Discount management";
            tabPageDiscount.UseVisualStyleBackColor = true;
            tabPageDiscount.Click += tabPageDiscount_Click;
            // 
            // guna2TabControlManagement
            // 
            guna2TabControlManagement.Controls.Add(tabPageDiscount);
            guna2TabControlManagement.Controls.Add(tabPageFeedback);
            guna2TabControlManagement.Controls.Add(tabPageInvoice);
            guna2TabControlManagement.Controls.Add(tabPageDelivery);
            guna2TabControlManagement.Controls.Add(tabPageManagement);
            guna2TabControlManagement.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TabControlManagement.HotTrack = true;
            guna2TabControlManagement.ItemSize = new Size(175, 55);
            guna2TabControlManagement.Location = new Point(0, 54);
            guna2TabControlManagement.Name = "guna2TabControlManagement";
            guna2TabControlManagement.SelectedIndex = 0;
            guna2TabControlManagement.Size = new Size(1264, 707);
            guna2TabControlManagement.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControlManagement.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControlManagement.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControlManagement.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControlManagement.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControlManagement.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControlManagement.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControlManagement.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControlManagement.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControlManagement.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControlManagement.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControlManagement.TabButtonSelectedState.FillColor = Color.White;
            guna2TabControlManagement.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControlManagement.TabButtonSelectedState.ForeColor = Color.Black;
            guna2TabControlManagement.TabButtonSelectedState.InnerColor = Color.White;
            guna2TabControlManagement.TabButtonSize = new Size(175, 55);
            guna2TabControlManagement.TabIndex = 1;
            guna2TabControlManagement.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControlManagement.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // ManagerWindow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Bisque;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1264, 761);
            Controls.Add(guna2TabControlManagement);
            Controls.Add(guna2GradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management";
            Load += ManagerWindow_Load;
            guna2TabControlManagement.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private TabPage tabPageManagement;
        private TabPage tabPageDelivery;
        private TabPage tabPageInvoice;
        private TabPage tabPageFeedback;
        private TabPage tabPageDiscount;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControlManagement;
    }
}