using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Testing");
        }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string CNIC { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
    }
}
