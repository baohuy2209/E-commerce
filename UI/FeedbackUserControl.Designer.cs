namespace UI
{
    partial class FeedbackUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            labelAverageScore = new Label();
            labelStar = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(838, 77);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.Size = new Size(237, 46);
            guna2RatingStar1.TabIndex = 0;
            // 
            // labelAverageScore
            // 
            labelAverageScore.AutoSize = true;
            labelAverageScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAverageScore.Location = new Point(838, 39);
            labelAverageScore.Name = "labelAverageScore";
            labelAverageScore.Size = new Size(177, 32);
            labelAverageScore.TabIndex = 1;
            labelAverageScore.Text = "Average Score";
            // 
            // labelStar
            // 
            labelStar.AutoSize = true;
            labelStar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStar.Location = new Point(1021, 29);
            labelStar.Name = "labelStar";
            labelStar.Size = new Size(65, 45);
            labelStar.TabIndex = 2;
            labelStar.Text = "0.0";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FeedbackUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelStar);
            Controls.Add(labelAverageScore);
            Controls.Add(guna2RatingStar1);
            Name = "FeedbackUserControl";
            Size = new Size(1142, 514);
            Load += FeedbackUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Label labelAverageScore;
        private Label labelStar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource bindingSource1;
    }
}
