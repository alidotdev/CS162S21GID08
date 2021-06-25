using Sem2FProject.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class FlightData
    {
        private static FlightData Data { get; set; }

        public List<Flight> Flights { get; set; }
        

        private FlightData()
        {
            Flights = new List<Flight>();
        }
        public static FlightData GetInstance()
        {
            if (Data == null)
            {
                Data = new FlightData();
            }
            return Data;
        }
        public void AddFlightData(Flight flight)
        {
            Flights.Add(flight);
        }
        public void SaveFlight()
        {
            StreamWriter stream = new StreamWriter("..\\..\\DataFiles\\Flights.csv");
            for (int i = 0; i < Flights.Count; i++)
            {
                Flight user = Flights[i];
                stream.WriteLine(user.FlightID+","+user.Departure + "," + user.Destination+ "," + user.BookedAirline+ "," + user.ReservedSeats);
            }
            stream.Close();
        }
        
        public void LoadFlight()
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\DataFiles\\Flights.csv");
                Flight user = new Flight();
                Flights = new List<Flight>();
                String line = stream.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(',');
                    user.FlightID = arr[0];
                    user.Departure = arr[1];
                    user.Destination = arr[2];
                    user.BookedAirline = arr[3];
                    user.ReservedSeats = Int32.Parse(arr[4]);
                    Flights.Add(user);
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
