using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class FlightData
    {
        private static FlightData Data { get; set; }

        public List<Flight> Flights { get; }

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
    }
}
