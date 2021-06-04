using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    class Admin : Person
    {
        public string FilePath;
        public static Admin admin;
        public static Admin GetInstance()
        {
            if (admin == null)
            {
                admin = new Admin();
                admin.FileLoad();
            }
            return admin;
        }
        private Admin()
        {
            Email = "admin@gmail.com";
            Password = "Admin123";
        }

        public void FileWrite()
        {

            StreamWriter writer = new StreamWriter("AdminInfo.txt");
            writer.WriteLine(admin.FirstName);
            writer.WriteLine(admin.Gender);
            writer.WriteLine(admin.CNIC);
            writer.WriteLine(admin.Email);
            writer.WriteLine(admin.Age);
            writer.WriteLine(admin.Password);
            writer.WriteLine(admin.FilePath);
            writer.Flush();
            writer.Close();

        }

        public void FileLoad()
        {

            //FileStream fs = FileStream("AdminInfo.txt");
            StreamReader read = new StreamReader("AdminInfo.txt");
            string name = read.ReadLine();

            if ((name == null) || name == "")
            {

                read.Close();
                return;
            }

            admin.FirstName = name;

            Gender = read.ReadLine();
            admin.CNIC = read.ReadLine();
            admin.Email = read.ReadLine();
            MessageBox.Show(admin.Email);
            int age = Int32.Parse(read.ReadLine());
            if (age < 18)
            {
                admin.Age = 18;

            }
            else
            {
                admin.Age = age;
            }
            admin.Password = read.ReadLine();
            admin.FilePath = read.ReadLine();

            read.Close();

        }

    }
}
