using BankHub_6._0;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BankHub_6._7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static int userNow { get; set; }
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            ApplicationContext _db = new ApplicationContext();

            //foreach (var user in _db.Users)
            //{
            //    var credit = _db.CreditAccs.ToList().Find(item => item.UserId.Equals(user.Id));

            //    if (credit != null)
            //    {
            //        var creditNow = _db.CreditAccs.Find(credit.Id);

            //        if (creditNow != null)
            //        {
            //            Credit.FactorialAsync(creditNow);
            //        }
            //    }

            //}
        }
    }
}
