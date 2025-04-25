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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            roundedboxMain.Parent = pictureBG;
            //roundedboxMain.BackColor = Color.FromArgb(200, Color.White);
            roundedboxMain.BackColor = Color.Transparent;
        }
    }
}
