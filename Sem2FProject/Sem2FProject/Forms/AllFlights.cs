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
    public partial class AllFlights : Form
    {
        public AllFlights()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().Show();
        }

        private void AllFlights_Load(object sender, EventArgs e)
        {
            List<Flight> list = FlightData.GetInstance().Flights;
            for(int i = 0; i < list.Count; i++)
            {
                String[] row = new string[] { list[i].FlightID, list[i].BookedAirline, list[i].Departure, list[i].Destination, ""+list[i].ReservedSeats };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
