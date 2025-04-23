namespace UI
{
    public partial class ReEnterPasswordWindow : Form
    {
        private RoundedBox roundedTextBoxNewPassword;

        public ReEnterPasswordWindow()
        {
            InitializeComponent();
            InitializeCustomControls();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt form ở giữa màn hình (từ yêu cầu trước)
            this.AutoScaleMode = AutoScaleMode.Dpi; // Tự động điều chỉnh theo DPI màn hình
        }

        private void InitializeCustomControls()
        {
            // Create and configure the RoundedBox
            roundedTextBoxNewPassword = new RoundedBox
            {
                Size = new Size(300, 50), // Adjust size as needed
                Location = new Point(130, 250), // Adjust position as needed
                BorderRadius = 20,
                BorderWidth = 2,
                BorderColor = Color.Gray,
                BackColor = Color.Transparent
            };

            // Add the RoundedBox to the form's controls
            this.Controls.Add(roundedTextBoxNewPassword);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Access the text from the RoundedBox's embedded TextBox
            string newPassword = roundedTextBoxNewPassword.Text;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
            }
            else
            {
                MessageBox.Show($"New Password: {newPassword}");
                // Add logic to handle the new password submission
            }
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            // This method is no longer needed for the RoundedBox implementation
            // You can remove this if not required
        }

        private void ReEnterPasswordWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
