using System;
using System.Collections.Generic;
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
            get;
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
    }
}
