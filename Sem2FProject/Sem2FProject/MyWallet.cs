using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2FProject
{
    class MyWallet
    {
        private string WalletID { get; }
        private int Balance { get; set; }
        private List <Transaction> History { get;}
        static long day = 0;
        static char ch = 'A';
        public MyWallet()
        {
            History = new List<Transaction>();
            WalletID = WalletIDGen();
        }

        //public string day = today.Day.ToStrin); 

        public void DepositMoney(int number)
        {
            Balance += number;
            Transaction obj = new Transaction();
            obj.Date = DateTime.Today;
            obj.Amount = number;
            obj.Type = "Deposit";
            History.Add(obj);
        }

        public bool WithDraw(int number)
        {
            if(Balance > number)
            {
                
                Transaction obj = new Transaction();
                obj.Date = DateTime.Today;
                obj.Amount = number;
                obj.Type = "Withdraw";
                History.Add(obj);
                return true;

            }
            else
            {
                return false ;
            }
        }

        public string WalletIDGen()
        {
            if(day == long.MaxValue)
            {
                day = 0;
                ch = (char)(ch+1);
            }
            day++;
           
            return ""+ch+day;
        }
    }
}
