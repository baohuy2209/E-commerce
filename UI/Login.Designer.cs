namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonReadMore = new Button();
            panel2 = new Panel();
            Authentication = new GroupBox();
            label3 = new Label();
            checkBoxTermAndPolicy = new CheckBox();
            buttonLogin = new Button();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            Authentication.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1136, 644);
            splitContainer1.SplitterDistance = 542;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 644);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonReadMore);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 623);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonReadMore
            // 
            buttonReadMore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonReadMore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReadMore.Location = new Point(173, 329);
            buttonReadMore.Name = "buttonReadMore";
            buttonReadMore.Size = new Size(158, 49);
            buttonReadMore.TabIndex = 1;
            buttonReadMore.Text = "READ MORE";
            buttonReadMore.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(Authentication);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 644);
            panel2.TabIndex = 0;
            // 
            // Authentication
            // 
            Authentication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Authentication.Controls.Add(label3);
            Authentication.Controls.Add(checkBoxTermAndPolicy);
            Authentication.Controls.Add(buttonLogin);
            Authentication.Controls.Add(textBoxEmail);
            Authentication.Controls.Add(label2);
            Authentication.Controls.Add(textBoxPassword);
            Authentication.Location = new Point(22, 65);
            Authentication.Name = "Authentication";
            Authentication.Size = new Size(547, 567);
            Authentication.TabIndex = 9;
            Authentication.TabStop = false;
            Authentication.Text = "Authentication";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 40);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // checkBoxTermAndPolicy
            // 
            checkBoxTermAndPolicy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxTermAndPolicy.AutoSize = true;
            checkBoxTermAndPolicy.Location = new Point(19, 273);
            checkBoxTermAndPolicy.Name = "checkBoxTermAndPolicy";
            checkBoxTermAndPolicy.Size = new Size(335, 29);
            checkBoxTermAndPolicy.TabIndex = 8;
            checkBoxTermAndPolicy.Text = "I agree all term condition and policy";
            checkBoxTermAndPolicy.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(105, 323);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(338, 49);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(19, 89);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(508, 39);
            textBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 148);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(19, 195);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(508, 39);
            textBoxPassword.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(40, 51);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Shop Store";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 644);
            Controls.Add(splitContainer1);
            Name = "Login";
            Text = "Login";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Authentication.ResumeLayout(false);
            Authentication.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonReadMore;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label1;
        private CheckBox checkBoxTermAndPolicy;
        private Button button3;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox Authentication;
    }
}