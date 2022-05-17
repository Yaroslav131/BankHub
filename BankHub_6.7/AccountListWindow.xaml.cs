using System.Linq;
using System.Windows;

namespace BankHub_6._7
{
    /// <summary>
    ///     Логика взаимодействия для AccountListWindow.xaml
    /// </summary>
    public partial class AccountListWindow : Window
    {
        private readonly ApplicationContext _db;


        public AccountListWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void AccountsGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            var accounts = _db.Accounts.ToList();

            var userAccounts = accounts.Where(account => account.UserId == App.userNow).ToList();

            var user = _db.Users.Find(App.userNow);

            var userAccs = userAccounts
                .Select(t => new  {User = user.Name, Name = t.AccountName, Score = $"{t.Score} $"}).ToList();

            AccountsGrid.ItemsSource = userAccs;
        }
    }
}