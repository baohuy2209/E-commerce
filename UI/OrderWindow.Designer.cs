namespace UI
{
    partial class OrderWindow
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
            buttonUpdate = new Button();
            buttonClose = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.Info;
            buttonUpdate.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(232, 464);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(157, 59);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += button2_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.Info;
            buttonClose.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(493, 464);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(157, 59);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(184, 172);
            listView1.Name = "listView1";
            listView1.Size = new Size(517, 264);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // OrderWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.White_and_Beige_Key_Rooms_to_Sell_Real_Estate_Facebook_Post2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 632);
            Controls.Add(listView1);
            Controls.Add(buttonClose);
            Controls.Add(buttonUpdate);
            Name = "OrderWindow";
            Text = "OrderWindow";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonUpdate;
        private Button buttonClose;
        private ListView listView1;
    }
}