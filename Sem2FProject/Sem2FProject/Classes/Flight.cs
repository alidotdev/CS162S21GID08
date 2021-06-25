using Sem2FProject.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    public class Flight
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
        public int ReservedSeats
        {
            get; set;
        }
        public Flight()
        {
            FlightID = FlightIDGen();
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
