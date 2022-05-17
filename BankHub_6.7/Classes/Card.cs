using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHub_6._7
{
    public class Card
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string BestBeforeDate { get; set; }
        public string Cvc { get; set; }
        public string TypeOfCard { get; set; }
        public string MainNumber { get; set; }
        public string CardName { get; set; }
        public string Password { get; set; }
        public bool BlockStatus { get; set; }
        public bool CreditStatus { get; set; }

        public Card()
        {

        }
        public Card(int accountId, int userId, string type, string number, string cvc, string data, string password, string name)
        {
            BlockStatus =false;
            CreditStatus = false;
            CardName = name;
            AccountId = accountId;
            BestBeforeDate = data;
            Cvc = cvc;
            TypeOfCard = type;
            MainNumber = number;
            UserId = userId;
            Password = password;
        }
    }
}
