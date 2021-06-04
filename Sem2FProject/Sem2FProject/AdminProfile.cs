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
        public AdminProfile()
        {
            InitializeComponent();
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
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF";
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
            StreamWriter writer = new StreamWriter(filePath);

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
            
        }
    }
}
