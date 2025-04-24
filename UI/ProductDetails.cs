using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            labelCategory.Parent = pictureBG;
            labelCategory.BackColor = Color.Transparent;
            labelName.Parent = pictureBG;
            labelName.BackColor = Color.Transparent;
            labelPrice.Parent = pictureBG;
            labelPrice.BackColor = Color.Transparent;
            labelQ.Parent = pictureBG;
            labelQ.BackColor = Color.Transparent;
            labelRFY.Parent = pictureBG;
            labelRFY.BackColor = Color.Transparent;
            labelRSP1.Parent = pictureBG;
            labelRSP1.BackColor = Color.Transparent;
            labelRSP2.Parent = pictureBG;
            labelRSP2.BackColor = Color.Transparent;
            labelRSP3.Parent = pictureBG;
            labelRSP3.BackColor = Color.Transparent;
            //5sp
            pictureboxStar1.Parent = pictureBG;
            pictureboxStar1.BackColor = Color.Transparent;
            pictureboxStar2.Parent = pictureBG;
            pictureboxStar2.BackColor = Color.Transparent;
            pictureboxStar3.Parent = pictureBG;
            pictureboxStar3.BackColor = Color.Transparent;
            pictureboxStar4.Parent = pictureBG;
            pictureboxStar4.BackColor = Color.Transparent;
            pictureboxStar5.Parent = pictureBG;
            pictureboxStar5.BackColor = Color.Transparent;

            roundedboxStar.BringToFront();

            for (int i = 1; i <= 5; i++)
            {
                PictureBox pb = (PictureBox)this.Controls.Find("pictureboxStar" + i, true).FirstOrDefault();
                if (pb != null)
                {
                    pb.BackColor = Color.Transparent;
                    pb.Location = new Point(14 + (i - 1) * 34, 6); 
                    pb.Parent = roundedboxStar;
                    roundedboxStar.Controls.Add(pb);
                }
            }

        }
    }
}
