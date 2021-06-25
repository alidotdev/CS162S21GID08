using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class UserData
    {
        public List<User> userList
        {
            get; set;
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
            SaveUsers();
        }
        public void SaveUsers()
        {
            StreamWriter stream = new StreamWriter("..\\..\\DataFiles\\Users.csv");
            for (int i = 0; i < userList.Count; i++)
            {
                User user = userList[i];
                stream.WriteLine(user.FirstName + "," + user.LastName + "," + user.Password + "," + user.CNIC + "," + user.Age + "," + user.Email + "," + user.Gender);
            }
            stream.Close();
        }

        public void LoadUsers()
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\DataFiles\\Users.csv");
                User user = new User();
                userList = new List<User>();
                String line = stream.ReadLine();
                while (line != null)
                {
                    String[] arr = line.Split(',');
                    user.FirstName = arr[0];
                    user.LastName = arr[1];
                    user.Password = arr[2];
                    user.CNIC = arr[3];
                    user.Age = Int32.Parse(arr[4]);
                    user.Email = arr[5];
                    user.Gender = arr[6];
                    userList.Add(user);
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
