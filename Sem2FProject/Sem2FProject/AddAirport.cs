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
    public partial class AddAirport : Form
    {
        public AddAirport()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String city = CityNBox.Text;
            String country = CountryNBox.Text;
            String code = CodeBox.Text;

            Airport airport = new Airport();
            airport.CityName = city;
            airport.CountryCode = code;
            airport.CountryName = country;
            AirportData.GetInstance().AddAirport(airport);
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
