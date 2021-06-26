using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject.Forms
{
    public partial class UserHomeScreen : MaterialForm
    {
        public UserHomeScreen()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo500, Primary.BlueGrey500, Accent.DeepPurple400, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 3;

        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 4;
        }

        private void bookFlightBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;

        }

        private void viewFlightBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;

        }

        private void updateFlightBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 5;

        }
    }
}
