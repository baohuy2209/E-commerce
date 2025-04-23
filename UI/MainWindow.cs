namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt form ở giữa màn hình (từ yêu cầu trước)
            this.AutoScaleMode = AutoScaleMode.Dpi; // Tự động điều chỉnh theo DPI màn hình
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            labelSP1.Parent = pictureBG;
            labelSP2.Parent = pictureBG;
            labelFooter.Parent = pictureBG;
            labelTitle.Parent = pictureBG;
            labelSP1.BackColor = Color.Transparent;
            labelSP2.BackColor = Color.Transparent;
            labelFooter.BackColor = Color.Transparent;
            labelTitle.BackColor = Color.Transparent;
            //buttonHome.BackColor = Color.Transparent;
        }
        private void labelSP2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBG_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            // Tạo instance của LoginWindow
            LoginWindow loginWindow = new LoginWindow();

            // Hiển thị LoginWindow
            loginWindow.Show();

            // Ẩn MainWindow
            this.Hide();
        }
    }
}

