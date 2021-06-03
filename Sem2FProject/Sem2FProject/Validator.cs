using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class Validator
    {
        private static Validator validator;
        private Validator() { }

        public static Validator GetInstance()
        {
            if (validator == null)
            {
                validator = new Validator();
            }
            return validator;
        }
        public bool isValidAlphaStr(String str)
        {
            int len = str.Length;
            if (len > 1)
            {
                for (int i = 0; i < len; i++)
                {
                    if (!(str[i] >= 'A' && str[i] <= 'Z'))
                    {
                        if (!(str[i] >= 'a' && str[i] <= 'z'))
                        {
                            if (!(str[i] == ' '))
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool isValidPassword(String str)
        {
            int len = str.Length;
            if (len > 5)
            {
                for (int i = 0; i < len; i++)
                {
                    if (!(str[i] >= 'A' && str[i] <= 'Z'))
                    {
                        if (!(str[i] >= 'a' && str[i] <= 'z'))
                        {
                            if (!(str[i] >= '0' && str[i] <= '9'))
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool isValidEmail(String EmailID)
        {
            if (EmailID.Contains("@"))
            {
                for (int i = 0; i < EmailID.Length; i++)
                {
                    if (!(EmailID[i] >= 'A' && EmailID[i] <= 'Z'))
                    {
                        if (!(EmailID[i] >= 'a' && EmailID[i] <= 'z'))
                        {
                            if (!(EmailID[i] >= '0' && EmailID[i] <= '9'))
                            {
                                if (!(EmailID[i] >= '-'))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool isValidContPhone(String num)
        {
            if (num.Length == 11)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (!(num[i] >= '0' && num[i] <= '9'))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isValidInteger(String n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (!(n[i] >= '0' && n[i] <= '9'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
