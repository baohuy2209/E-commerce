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
    public partial class MyCart : Form
    {
        public MyCart()
        {
            InitializeComponent();
        }

        private void MyCart_Load(object sender, EventArgs e)
        {
            //tao hinh cn co vien den
            PictureBox boxtemp = new PictureBox();
            boxtemp.Dock = DockStyle.Fill;
            boxtemp.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(boxtemp);

            //box selectall
            RoundedBox boxAll = new RoundedBox()
            {
                Size = new Size(750, 80),
                Location = new Point(130, 250),
                BorderRadius = 20,
                BorderWidth = 2,
                BorderColor = Color.Black,
                BackColor = Color.Transparent 
            };

            this.Controls.Add(boxAll);
            boxAll.BringToFront();

            buttonDelete.Location = new Point(610, 14);
            boxAll.Controls.Add(buttonDelete);

            checkboxSA.BackColor = Color.Transparent;
            checkboxSA.Location = new Point(34, 27);
            checkboxSA.Parent = boxAll;
            boxAll.Controls.Add(checkboxSA);

            //box SP
            RoundedBox boxSP = new RoundedBox()
            {
                Size = new Size(750, 160),
                Location = new Point(130, 350),
                BorderRadius = 20,
                BorderWidth = 2,
                BorderColor = Color.Black,
                BackColor = Color.Transparent
            };

            this.Controls.Add(boxSP);
            boxSP.BringToFront();

            checkboxSelect.BackColor = Color.Transparent;
            checkboxSelect.Location = new Point(34, 27);
            checkboxSelect.Parent = boxSP;
            boxSP.Controls.Add(checkboxSelect);

            pictureboxImage.BackColor = Color.Transparent;
            pictureboxImage.Location = new Point(64, 27);
            pictureboxImage.Parent = boxSP;
            boxSP.Controls.Add(pictureboxImage);

            labelCategory.BackColor = Color.Transparent;
            labelCategory.Location = new Point(184, 27);
            labelCategory.Parent = boxSP;
            boxSP.Controls.Add(labelCategory);

            labelName.BackColor = Color.Transparent;
            labelName.Location = new Point(184, 60);
            labelName.Parent = boxSP;
            boxSP.Controls.Add(labelName);

            labelPrice.BackColor = Color.Transparent;
            labelPrice.Location = new Point(180, 90);
            labelPrice.Parent = boxSP;
            boxSP.Controls.Add(labelPrice);

            buttonAdd.Location = new Point(680, 100);
            boxSP.Controls.Add(buttonAdd);

            buttonMinus.Location = new Point(580, 100);
            boxSP.Controls.Add(buttonMinus);

            textboxAmount.Location = new Point(630, 100);
            boxSP.Controls.Add(textboxAmount);

            //box TT
            RoundedBox boxTT = new RoundedBox()
            {
                Size = new Size(300, 180),
                Location = new Point(920, 250),
                BorderRadius = 20,
                BorderWidth = 2,
                BorderColor = Color.Black,
                BackColor = Color.Transparent
            };

            this.Controls.Add(boxTT);
            boxTT.BringToFront();

            labelSO.BackColor = Color.Transparent;
            labelSO.Location = new Point(24, 17);
            labelSO.Parent = boxTT;
            boxTT.Controls.Add(labelSO);

            labelTotal.BackColor = Color.Transparent;
            labelTotal.Location = new Point(24, 70);
            labelTotal.Parent = boxTT;
            boxTT.Controls.Add(labelTotal);

            labelTP.BackColor = Color.Transparent;
            labelTP.Location = new Point(140, 57);
            labelTP.Parent = boxTT;
            boxTT.Controls.Add(labelTP);

            buttonPurchase.Location = new Point(90, 110);
            boxTT.Controls.Add(buttonPurchase);

            labelMC.Parent = pictureBG;
            labelMC.BackColor = Color.Transparent;
        }
    }
}
