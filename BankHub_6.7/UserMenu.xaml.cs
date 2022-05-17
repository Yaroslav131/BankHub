using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BankHub_6._7
{
    public partial class UserMenu : Window
    {
        private ApplicationContext _db;

        public UserMenu()
        {
            InitializeComponent();

        }

        private void AddAccClick(object sender, RoutedEventArgs e)
        {
            var accountWindow = new AddAccountWindow();

            accountWindow.ShowDialog();
        }

        private void DeleteAccClick(object sender, RoutedEventArgs e)
        {
            var deleteAccWindow = new DeleteAccWindow();

            deleteAccWindow.ShowDialog();
        }

        private void AddCardClick(object sender, RoutedEventArgs e)
        {
            var addCardWindow = new AddCardWindow();

            addCardWindow.ShowDialog();
        }

        private void DeleteCardClick(object sender, RoutedEventArgs e)
        {
            var deleteCardWindow = new DeleteCardWindow();

            deleteCardWindow.ShowDialog();
        }

        private void AddMoneyClick(object sender, RoutedEventArgs e)
        {
            var addMoneyWindow = new AddMoneyWindow();

            addMoneyWindow.ShowDialog();

        }

        private void GetMoneyClick(object sender, RoutedEventArgs e)
        {
            var getMoneyWindow = new GetMoneyWindow();

            getMoneyWindow.ShowDialog();
        }

        private void TransitMoneyClick(object sender, RoutedEventArgs e)
        {
            var transitMoneyWindow = new TransitMoneyWindow();

            transitMoneyWindow.ShowDialog();
        }

        private void TransitOtherMoneyClick(object sender, RoutedEventArgs e)
        {
            var transitMoneyWindow = new TransitMoneyToOhterAccountWindow();

            transitMoneyWindow.ShowDialog();
        }


        private void GetCreditClick(object sender, RoutedEventArgs e)
        {
            var loanConditionsWindow = new LoanConditionsWindow();

            loanConditionsWindow.ShowDialog();
        }

        private void NewsClick(object sender, RoutedEventArgs e)
        {
            var newsWindow = new NewsWindow();

            newsWindow.Show();
        }

        private void MapClick(object sender, RoutedEventArgs e)
        {
            var mapWindow = new MapWindow();

            mapWindow.Show();
        }

        private void User_OnClick(object sender, RoutedEventArgs e)
        {
            var redactAccWindow = new UserRedactAccWindow();

            redactAccWindow.ShowDialog();

            if (redactAccWindow.DialogResult == true)
            {
                this.Close();
            }
            else
            {

                UserName_Loaded();
            }

        }

        private void ShowListCardClick(object sender, RoutedEventArgs e)
        {
            var cardListWindow = new CardListWindow();

            cardListWindow.ShowDialog();
        }

        private void ShowListAccClick(object sender, RoutedEventArgs e)
        {
            var accountListWindow = new AccountListWindow();

            accountListWindow.ShowDialog();
        }

        private void UserName_Loaded()
        {
            _db = new ApplicationContext();

            _db.Users.Load();

            var user = _db.Users.Find(App.userNow);


            if (user != null)
            {
                UserName.Text = $"{user.Name}  {user.LastName}";

                //UserImage.Background = new ImageBrush(new BitmapImage(
                //    new Uri($@"{user.AvatarImage}", UriKind.Relative)));
            }


        }

        private void UserName_OnLoaded(object sender, RoutedEventArgs e)
        {
            UserName_Loaded();
        }

        private void CreditListClicK(object sender, RoutedEventArgs e)
        {
            var accountListWindow = new CreditAccList();

            accountListWindow.ShowDialog();
        }

        private void PayCredit(object sender, RoutedEventArgs e)
        {
            var payCredit = new PayCredit();

            payCredit.ShowDialog();

        }

        private void LastOperation(object sender, RoutedEventArgs e)
        {
            var oper = new LastOperation();

            oper.ShowDialog();
        }
    }
}


