using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    public partial class AdminProfile : Form
    {
        private static string filePath { get; set; }
        //private Admin Admin1 { get; set; }
        public AdminProfile()
        {

            InitializeComponent();
            label5.Hide();
            label6.Hide();
            label10.Hide();
            label11.Hide();
            label15.Hide();
            Admin admin = Admin.GetInstance();
            textBox1.Text = admin.FirstName;
            textBox2.Text = admin.Email;
            maskedTextBox1.Text = admin.CNIC;
            passwordBox.Text = admin.Password;
            if (admin.Gender == "Male")
            {
                maleBtn.Select();
            }
            else
            {
                femaleBtn.Select();
            }
            numericUpDown1.Text = "" + admin.Age;

            //MyImage = new Bitmap(@"C:\Users\Muhammad Ali Murtaza\OneDrive\Desktop\Semester 2\OOP Theory\Final Project\CS162S21GID08\Sem2FProject\Sem2FProject\Images\SirSamyan.jpg");
            //pictureBox1.Image = (Image)MyImage;
        }

        public Bitmap MyImage { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)F|*.BMP;*.JPG;*.JPEG;*.GI)";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            if (filePath != null)
            {
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                MyImage = new Bitmap(filePath);
                ////pictureBox1.ClientSize = new Size(147, 158);
                pictureBox1.Image = (Image)MyImage;
                //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Validator v = Validator.GetInstance();
            if (v.isValidAlphaStr(textBox1.Text) && v.isValidEmail(textBox2.Text) && maskedTextBox1.Text.Length == 15
                && (maleBtn.Checked || femaleBtn.Checked) && v.isValidPassword(passwordBox.Text))
            {
                Admin.GetInstance().FirstName = textBox1.Text;
                Admin.GetInstance().Email = textBox2.Text;
                Admin.GetInstance().CNIC = maskedTextBox1.Text;

                if (maleBtn.Checked)
                {
                    Admin.GetInstance().Gender = "Male";
                }
                else
                {
                    Admin.GetInstance().Gender = "Male";
                }
                Admin.GetInstance().Age = (int)numericUpDown1.Value;
                Admin.GetInstance().Password = passwordBox.Text;
                Admin.GetInstance().FileWrite();
                this.Hide();
                new AdminHome().Show();
            }
            else
            {
                if (!v.isValidAlphaStr(textBox1.Text))
                {
                    label5.Show();
                }
                if (!v.isValidEmail(textBox2.Text))
                {
                    label6.Show();
                }
                if (!(maskedTextBox1.Text.Length == 15))
                {
                    label10.Show();
                }
                if (!(maleBtn.Checked || femaleBtn.Checked))
                {
                    label11.Show();
                }
                if (!v.isValidPassword(passwordBox.Text))
                {
                    label15.Show();
                }

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            label10.Hide();
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            label15.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().Show();
        }

        private void femaleBtn_Click(object sender, EventArgs e)
        {
            label11.Hide();
        }

        private void maleBtn_Click(object sender, EventArgs e)
        {
            label11.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';

            }
        }
    }
}
