using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankHub_6._7
{
    /// <summary>
    /// Логика взаимодействия для CreditAccList.xaml
    /// </summary>
    public partial class CreditAccList : Window
    {
        ApplicationContext _db;

        public CreditAccList()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void AccountsGrid_OnLoaded(object sender, RoutedEventArgs e)
        {

            var creditAccounts = _db.CreditAccs.ToList();

            var userAccounts = creditAccounts.Where(account => account.UserId == App.userNow).ToList();

            var user = _db.Users.Find(App.userNow);

            var userAccs = userAccounts.Select(t => new  { User = user.Name, CardName = t.CardName, Money = $"{t.Money } $", CreditPerCent = $"{t.CreditPerCent } %", DataEnd = t.DataEnd, DataStart = t.DataStart }).ToList();

            AccountsGrid.ItemsSource = userAccs;

        }
    }
}
