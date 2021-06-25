using Sem2FProject.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    public class Airline
    {
        public String Name
        {
            get;set;
        }
        public List<Classes.FlightClass> ClassesInFlight;
        public Airline()
        {
            ClassesInFlight = new List<Classes.FlightClass>();
        }
        public int TotalSeats
        {
            get;set;
        }
        
        public void SaveClasses()
        {
            StreamWriter stream = new StreamWriter("..\\..\\DataFiles\\" + this.Name + "Classes.csv");
            for (int i = 0; i < ClassesInFlight.Count; i++)
            {
                FlightClass user = ClassesInFlight[i];
                stream.WriteLine(user.ClassName + "," + user.Fare + "," + user.NoOfSeats);
            }
            stream.Close();
        }
        public void LoadClasses()
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\DataFiles\\" + this.Name + "Classes.csv");
                FlightClass user = new FlightClass();
                ClassesInFlight = new List<FlightClass>();
                String line = stream.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(',');
                    user.ClassName = arr[0];
                    user.Fare = Int32.Parse(arr[1]);
                    user.NoOfSeats = Int32.Parse(arr[2]);
                    ClassesInFlight.Add(user);
                    line = stream.ReadLine();
                }
                stream.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
