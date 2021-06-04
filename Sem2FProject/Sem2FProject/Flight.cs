using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class Flight
    {
        public String Departure
        {
            get; set;
        }
        public String Destination
        {
            get; set;
        }
        public String BookedAirline
        {
            get; set;
        }
        public String FlightID
        {
            get; set;
        }
        public String ReservedSeats
        {
            get; set;
        }
        public String ClassType
        {
            get; set;
        }
        public Flight()
        {
            FlightID = FlightIDGen();
            ReservedSeats = "";
        }
        public static String FlightIDGen()
        {
            String id = "ARS-FID-";
            Random random = new Random(DateTime.Now.Second);
            int d = random.Next(100, 999);
            id += d.ToString();
            return id;
        }
    }
}
