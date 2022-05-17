using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHub_6._7
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public double Score { get; set; }
        public int UserId { get; set; }

        public Account()
        {
        }

        public Account(string name, double money,int userId)
        {
            UserId = userId;
            AccountName = name;
            Score = money;
        }
    }
}
