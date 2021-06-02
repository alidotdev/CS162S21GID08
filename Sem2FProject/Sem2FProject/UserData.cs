using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class UserData
    {
        public List<User> userList
        {
            get;
        }
        private static UserData userInfo;
        public UserData()
        {
            userList = new List<User>();
        }
        public static UserData GetInstance()
        {
            if (userInfo == null)
            {
                userInfo = new UserData();
            }
            return userInfo;
        }
        public void AddUser(User us)
        {
            userList.Add(us);
        }
        
    }
}
