using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHub_6._7
{
  public  class CreditAcc
    {
        public int Id { get;set; }

        public string DataStart{ get; set; }

        public string CardName { get; set; }

        public string DataEnd { get; set; }

        public double CreditPerCent { get; set; }

        public double Money { get; set; }

        public int UserId { get; set; }

        public int CardId { get; set; }

        public CreditAcc()
        {

        }

        public CreditAcc(string dataStart, string cardName, string dataEnd,double perCent, int userId, int cardId, double money)
        {
            this.DataStart = dataStart;
             this.CardName = cardName;
             this.DataEnd = dataEnd;
             this.UserId = userId;
             this.CardId = cardId;
             this.CreditPerCent = perCent;
             this.Money = money;
        }
    }
}
