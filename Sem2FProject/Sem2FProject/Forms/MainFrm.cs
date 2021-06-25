using Bunifu.UI.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sem2FProject.Classes;
using Sem2FProject.Forms;
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
    public partial class MainFrm : MaterialForm
    {
        private Airline airline;
        private bool flag = true;
        public MainFrm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo500, Primary.BlueGrey500, Accent.DeepPurple400, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
            panel2.Enabled = false;
            emailLabel.Hide();
            flightSubMenuPanel.Hide();
            classTable.Hide();
            addBtnClass.Hide();
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            String mail = emailBox.Text;
            String pwd = passwordBox.Text;
            for (int i = 0; i < UserData.GetInstance().userList.Count; i++)
            {
                User user = UserData.GetInstance().userList[i];
                if (mail.Equals(user.Email) && pwd.Equals(user.Password))
                {
                    bunifuPages1.SelectedIndex = 1;
                    panel2.Enabled = true;
                }

                //if (mail.Equals("Admin") && pwd.Equals("Admin123"))
                //{
                //    bunifuPages1.SelectedIndex = 1;
                //    panel2.Show();
                //}

            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            regAgeBox.Text = "" + numericUpDown1.Value;
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void forgotPwdBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            String fname = regFirstNameBox.Text;
            if (!Validator.GetInstance().isValidAlphaStr(fname))
            {
                MessageBox.Show("Enter valid First Name! Use Only alphabets ");
                return;
            }
            String lname = regLastNameBox.Text;
            if (!Validator.GetInstance().isValidAlphaStr(lname))
            {
                MessageBox.Show("Enter valid Last Name! Use Only alphabets ");
                return;
            }
            String email = regEmailBox.Text;
            if (!Validator.GetInstance().isValidEmail(email))
            {
                MessageBox.Show("Enter valid Email!");
                return;
            }
            String pwd = regPasswordBox.Text;
            if (!Validator.GetInstance().isValidPassword(pwd))
            {
                MessageBox.Show("Enter valid Password!");
                return;
            }
            int age = 16;
            try
            {
                age = Int32.Parse(regAgeBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid Age!");
                return;
            }
            String gender = "Male";
            if (bunifuRadioButton1.Checked)
            {
                gender = "Female";
            }
            String Cnic = cnicBox.Text;
            if (Cnic == null || Cnic == "")
            {
                MessageBox.Show("Please Enter Cnic!");
                return;
            }
            User user = new User();
            user.FirstName = fname;
            user.LastName = lname;
            user.Email = email;
            user.CNIC = Cnic;
            user.Age = age;
            user.Gender = gender;
            user.Password = pwd;
            UserData.GetInstance().AddUser(user);
            MessageBox.Show("Successfull! Account has been created. Login to avail services");
            bunifuPages1.SelectedIndex = 0;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;
        }

        private void fpForgotPwdBtn_Click(object sender, EventArgs e)
        {
            emailLabel.Show();
            bool flag = false;
            String mail = fpEmailBox.Text;
            String Fname = fpFNameBox.Text;
            Validator v = Validator.GetInstance();

            List<User> list = UserData.GetInstance().userList;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(Fname) && list[i].Email.Equals(mail))
                {
                    Email email = Email.GetInstance();
                    if (email.SendPwdRecoveryEmail(list[i]))
                    {
                        flag = true;
                    }
                }
            }
            if (!(flag))
            {
                MessageBox.Show(null,"No data found for entered credentials","Error");
            }
        }

        private void fpSignInBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                flightSubMenuPanel.Show();
            }
            else
            {
                flightSubMenuPanel.Hide();
                flag = true;
            }
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 3;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex = 0;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex = 2;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex = 1;
        }


        private void continueBtn_Click(object sender, EventArgs e)
        {
            Flight objFlight = new Flight();
            addflightIDBox.Text = objFlight.FlightID;
            String dept = depComboBox.Text;
            String arr = arrivalComboBox.Text;
            String airline = airlineComboBox.Text;
            
            objFlight.Departure = dept;
            objFlight.Destination = arr;
            objFlight.BookedAirline = airline;
            FlightData.GetInstance().AddFlightData(objFlight);
        }


        private void addBtnClass_Click_1(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex = 3;
        }

        private void continueAirlineBtn_Click(object sender, EventArgs e)
        {
            String name = nameAirlineBox.Text;
            if (!Validator.GetInstance().isValidAlphaStr(name))
            {
                MessageBox.Show(null, "Enter Valid Airline Name!", "Error");
                return;
            }
            int seat;
            try
            {
                seat =Int32.Parse(seatsAirlineBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Enter Valid Airline Seats!", "Error");
                return;
            }
            airline = new Airline();
            airline.Name = name;
            airline.TotalSeats = seat;
            addBtnClass.Show();
            classTable.Show();
        }

        private void backClassBtn_Click(object sender, EventArgs e)
        {
            bunifuPages2.SelectedIndex = 2;
        }

        private void submitClassBtn_Click(object sender, EventArgs e)
        {
            String name = classNameBox.Text;
            if (!Validator.GetInstance().isValidAlphaStr(name))
            {
                MessageBox.Show(null, "Enter Valid Name!", "Error");
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
                seat = Int32.Parse(seatsBox.Text);
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
            MessageBox.Show(null, "Successful! Class has been added", "Error");
            classTable.Rows.Clear();
            for (int i = 0; i < airline.ClassesInFlight.Count; i++)
            {
                FlightClass fc = airline.ClassesInFlight[i];
                Object[] obj = new Object[3];
                obj[0] = fc.ClassName;
                obj[1] = fc.Fare;
                obj[2] = fc.NoOfSeats;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                classTable.Columns.Add(btn);
                btn.HeaderText = "EDIT";
                btn.Text = "Edit";
                btn.Name = "editBtn";
                btn.UseColumnTextForButtonValue = true;
                //obj[3] = btn;
                    //new Button() { Text="EDIT",Visible=true, Name="editBtn"});

                classTable.Rows.Add(obj);
            }
            bunifuPages2.SelectedIndex = 2;
            airline.SaveClasses();
        }
        public void editBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
