using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class User: Person
    {
        public MyWallet wallet { get; set; }
        public User()
        {
            reservedFlights = new List<Flight>();
        }
        public List<Flight> reservedFlights
        {
            get;set;
        }

    }
}
