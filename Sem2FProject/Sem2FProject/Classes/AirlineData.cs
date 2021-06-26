using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class AirlineData
    {
        private static AirlineData Data;
        public List<Airline> AirlineList
        {
            get; set;
        }

        private AirlineData()
        {
            AirlineList= new List<Airline>();
        }

        public static AirlineData GetInstance()
        {
            if (Data == null)
            {
                Data = new AirlineData();
            }
            return Data;
        }

        public void AddAirline(Airline airline)
        {
            AirlineList.Add(airline);
        }
        public void SaveAirline()
        {
            StreamWriter stream = new StreamWriter("..\\..\\DataFiles\\Airlines.csv");
            for (int i = 0; i < AirlineList.Count; i++)
            {
                Airline user = AirlineList[i];
                stream.WriteLine(user.Name + "," + user.TotalSeats);
                user.SaveClasses();
            }
            stream.Close();
        }
        public void LoadAirline()
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\DataFiles\\Airlines.csv");
                Airline user = new Airline();
                AirlineList = new List<Airline>();
                String line = stream.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(',');
                    user.Name = arr[0];
                    user.TotalSeats = Int32.Parse(arr[1]);
                    user.LoadClasses();
                    AirlineList.Add(user);
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
