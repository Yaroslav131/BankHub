using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для CardListWindow.xaml
    /// </summary>
    public partial class CardListWindow : Window
    {
        ApplicationContext _db;

        public CardListWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void CardsGrid_OnLoaded(object sender, RoutedEventArgs e)
        {

            _db.Accounts.Load();

            var cards = _db.Cards.ToList();

            var useCards = cards.Where(card => card.UserId == App.userNow).ToList();

            var accounts = _db.Accounts.ToList();

            var userAccounts = accounts.Where(account => account.UserId == App.userNow).ToList();


            var userCardsNow = useCards.Select(t => new { Account = userAccounts.Find(z=>z.Id.Equals(t.AccountId)), Name = t.CardName,
                Number = t.MainNumber, Data = t.BestBeforeDate, CVC = t.Cvc, Type = t.TypeOfCard, Password = "****" }).ToList();


          

            CardsGrid.ItemsSource = userCardsNow;


        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            CheckPassword password = new CheckPassword();
            this.Opacity = 0;
            password.ShowDialog();
            this.Opacity = 1;
            if (password.DialogResult == true)
            {
                var cards = _db.Cards.ToList();

                var useCards = cards.Where(card => card.UserId == App.userNow).ToList();

                var accounts = _db.Accounts.ToList();

                var userAccounts = accounts.Where(account => account.UserId == App.userNow).ToList();

                var userCardsNow = useCards.Select(t => new {
                    Account = userAccounts.Find(z => z.Id.Equals(t.AccountId)),
                    Name = t.CardName,
                    Number = t.MainNumber,
                    Data = t.BestBeforeDate,
                    CVC = t.Cvc,
                    Type = t.TypeOfCard,
                    Password = t.Password
                }).ToList();

                CardsGrid.ItemsSource = userCardsNow;
            }
        }
    }
}

