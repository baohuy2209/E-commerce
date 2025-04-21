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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            labelSP1.Parent = pictureBG;
            labelSP2.Parent = pictureBG;
            labelFooter.Parent = pictureBG;
            labelTitle.Parent = pictureBG;
            //buttonHome.Parent = pictureBG;
            labelSP1.BackColor = Color.Transparent;
            labelSP2.BackColor = Color.Transparent;
            labelFooter.BackColor = Color.Transparent;
            labelTitle.BackColor = Color.Transparent;
            //buttonHome.BackColor = Color.Transparent;
        }
        private void labelSP2_Click(object sender, EventArgs e)
        {

        }
    }
}

