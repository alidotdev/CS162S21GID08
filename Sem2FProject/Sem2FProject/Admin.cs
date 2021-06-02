using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class Admin: Person
    {
        private static Admin admin;
        public static Admin GetInstance()
        {
            if (admin == null)
            {
                admin = new Admin();
            }
            return admin;
        }
        private Admin()
        {
            Email = "admin@gmail.com";
            Password = "Admin123";
        }

    }
}
