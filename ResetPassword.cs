internal class ResetPassword : IDisposable
{
    private IContainer components;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        // Initialization logic here
    }

    private Button button1;
    private TextBox textBox5;
    private Label label1;
    private Label label2;
    private Button button2;
}
