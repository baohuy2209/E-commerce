namespace UI
{
    public partial class FeedbackUserControl : UserControl
    {
        public FeedbackUserControl()
        {
            InitializeComponent();
        }

        private void FeedbackUserControl_Load(object sender, EventArgs e)
        {
            // Ensure the correct type is used. PolarChart might not exist; RadarChart is likely the intended type.
            var radarChart = new LiveCharts.WinForms.CartesianChart
            {
                Location = new System.Drawing.Point(0, 0),

            }; // Replace PolarChart with CartesianChart
        }
    }
}
