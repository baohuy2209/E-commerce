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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelSI.Parent = pictureBG;
            labelAU.Parent = pictureBG;
            labelInfo.Parent = pictureBG;
            labelE.Parent = pictureBG;
            labelO.Parent = pictureBG;
            linklabelTAP.Parent = pictureBG;
            linklabelFP.Parent = pictureBG;
            linklabelRM.Parent = pictureBG;
            labelP.Parent = pictureBG;
            checkboxKMLI.Parent = pictureBG;
            //checkboxTAP.Parent = pictureBG;
            buttonSI.Parent = pictureBG;
            //pictureIcon.Parent = pictureBG;
            labelSI.BackColor = Color.Transparent;
            labelSI.BackColor = Color.Transparent;
            labelInfo.BackColor = Color.Transparent;
            labelO.BackColor = Color.Transparent;
            labelE.BackColor = Color.Transparent;
            labelP.BackColor = Color.Transparent;   
            linklabelTAP.BackColor = Color.Transparent;
            linklabelFP.BackColor = Color.Transparent;
            checkboxKMLI.BackColor = Color.Transparent;
            linklabelRM.BackColor = Color.Transparent;
            //checkboxTAP.BackColor = Color.Transparent;
            buttonSI.BackColor = Color.Transparent;
            //pictureIcon.BackColor = Color.Transparent;
        }
    }
}
