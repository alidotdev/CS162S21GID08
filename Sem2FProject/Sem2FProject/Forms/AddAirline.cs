using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    public partial class AddAirline : Form
    {
        public AddAirline()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            SeatCap.Value = 20;
            EconomySeat.Value = 1;
            BusinessSeat.Value = 1;
            EFairBox.Text = "";
            BFairBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airline ar = new Airline();
            String name = NameBox.Text;
            int cap = (int)SeatCap.Value;
            int economy = (int)EconomySeat.Value;
            int business = (int)BusinessSeat.Value;
            int eFare = Convert.ToInt32(EFairBox.Text);
            int bFare = Convert.ToInt32(BFairBox.Text);

            ar.Name = name;
            ar.TotalSeats = cap;
            //ar.EconomySeats = economy;
            //ar.BusinessSeats = business;
            //ar.EconomyFare = eFare;
            //ar.BusinessFare = bFare;
            AirlineData.GetInstance().AddAirline(ar);
            this.Hide();
        }
    }
        
}
