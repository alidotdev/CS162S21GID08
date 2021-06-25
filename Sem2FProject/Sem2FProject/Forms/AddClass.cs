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
using Sem2FProject.Classes;

namespace Sem2FProject
{
    public partial class AddClass : MaterialForm
    {
        private Airline airline;
        public AddClass(Airline f)
        {
            InitializeComponent();
            airline = f;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo500, Primary.BlueGrey500, Accent.DeepPurple400, TextShade.WHITE);
        }

        private void backClassBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitClassBtn_Click(object sender, EventArgs e)
        {
            String name = classNameBox.Text;
            if (!Validator.GetInstance().isValidAlphaStr(name))
            {
                MessageBox.Show(null, "Enter Valid Name!","Error");
                return;
            }
            int fare;
            try
            {
                fare = Int32.Parse(classfareBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Enter Valid Fare! Only Integers are Allowed", "Error");
                return;
            }
            int seat;
            try
            {
                seat = Int32.Parse(classfareBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Enter Valid Seat Numbers! Only Integers are Allowed", "Error");
                return;
            }
            FlightClass flightClass = new FlightClass();
            flightClass.ClassName = name;
            flightClass.Fare = fare;
            flightClass.NoOfSeats = seat;
            airline.ClassesInFlight.Add(flightClass);
            AirlineData.GetInstance().AddAirline(airline);
            this.Hide();
        }
    }
}

