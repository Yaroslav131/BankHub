using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BankHub_6._7
{
    class Credit
    {
        private static ApplicationContext db;

                                
    public    static async void FactorialAsync(CreditAcc creditAcc)
        {
            

            await Task.Run(() => CheckCredit(creditAcc));               
            
        }

        public static void CheckCredit(CreditAcc creditAcc)
        {
            db = new ApplicationContext();

            DateTime dataEnd = DateTime.Parse(creditAcc.DataEnd);

            db.Cards.Load();
            db.CreditAccs.Load();
            db.Users.Load();

    

            var creditAccount = db.CreditAccs.Find((creditAcc.Id));

            do
            {
                db = new ApplicationContext();

               

                 creditAccount = db.CreditAccs.Find((creditAcc.Id));
                var card = db.Cards.Find(creditAcc.CardId);
                

                if (creditAccount.Money > 0)
                {
                    card.CreditStatus = true;
                }

                if (creditAccount.Money == 0)
                {
                    card.CreditStatus = false;


                    //bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    //try
                    //{
                    //    db.Configuration.ValidateOnSaveEnabled = false;



                    //    db.CreditAccs.Attach(creditAccount);
                    //    db.Entry(creditAccount).State = EntityState.Deleted;
                    //    db.SaveChanges();
                    //}
                    //finally
                    //{
                    //    db.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                    //}


                    break;
                }

                db.SaveChanges();
            }
            while (DateTime.Now < dataEnd);


            db = new ApplicationContext();

            creditAccount = db.CreditAccs.Find((creditAcc.Id));

            if (creditAcc.Money>0)
            {
                var user = db.Users.Find(creditAcc.UserId);

                user.BlockStatus = true;
                db.CreditAccs.Remove(creditAccount);
                db.SaveChanges();
            }

           
        }

    }
}
