using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class AirportData
    {
        private static AirportData data;

        public List<Airport> Airports
        {
            get; set;
        }
        private AirportData()
        {
            Airports = new List<Airport>();
        }

        public static AirportData GetInstance()
        {
            if (data == null)
            {
                data = new AirportData();
            }
            return data;
        }
        public void AddAirport(Airport ar)
        {
            Airports.Add(ar);
        }
        public void SaveAirport()
        {
            StreamWriter stream = new StreamWriter("..\\..\\DataFiles\\Airport.csv");
            for (int i = 0; i < Airports.Count; i++)
            {
                Airport user = Airports[i];
                stream.WriteLine(user.CityName + "," + user.CountryName + "," + user.CountryCode);
            }
            stream.Close();
        }
        public void LoadAirports()
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\DataFiles\\Airport.csv");
                Airport user = new Airport();
                Airports = new List<Airport>();
                String line = stream.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(',');
                    user.CityName = arr[0];
                    user.CountryName = arr[1];
                    user.CountryCode = arr[2];
                    Airports.Add(user);
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
