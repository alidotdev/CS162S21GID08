using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateFlight : Form
    {
        public UpdateFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker4.ResetText();
            dateTimePicker3.ResetText();
        }

        
    }
}
