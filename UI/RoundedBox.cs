using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI
{
    public partial class RoundedBox : UserControl
    {
        [Category("Custom")]
        public int BorderRadius { get; set; } = 15;

        [Category("Custom")]
        public int BorderWidth { get; set; } = 2;

        [Category("Custom")]
        public Color BorderColor { get; set; } = Color.Black;

        public RoundedBox()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(BorderWidth / 2, BorderWidth / 2,
                                           this.Width - BorderWidth, this.Height - BorderWidth);

            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
