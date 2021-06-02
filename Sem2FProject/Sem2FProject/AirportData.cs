using System;
using System.Collections.Generic;
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
            get;
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
    }
}
