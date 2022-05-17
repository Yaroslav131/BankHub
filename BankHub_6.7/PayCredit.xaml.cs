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
    /// Логика взаимодействия для PayCredit.xaml
    /// </summary>
    public partial class PayCredit : Window
    {
        private bool _wrongInputValue;
        private char[] _charString;
        private int _cardId;
        private double moneyDouble;
        private string cardName;
        private string creditCardName;

        private ApplicationContext db;

        public PayCredit()
        {
            InitializeComponent();


            db = new ApplicationContext();

            var cards = db.Cards.ToList();

            var nameCardArray = new List<string>();

            for (int i = 0; i < cards.Count; i++)
            {

                if (cards[i].UserId.Equals(App.userNow))
                {
                    nameCardArray.Add(cards[i].CardName);
                }
            }

            credCardList.ItemsSource = nameCardArray;

            credCardList.Focus();

            var creditCards = db.Cards.ToList();

            var creditNameCardArray = new List<string>();

            for (int i = 0; i < creditCards.Count; i++)
            {

                if (creditCards[i].CreditStatus.Equals(1))
                {
                    creditNameCardArray.Add(creditCards[i].CardName);
                }
            }

            credCardList.ItemsSource = creditNameCardArray;

        }


        private void ComboBoxCard_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            cardName = comboBox.Name;

        }

        private void ComboBoxCreditCard_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            creditCardName = comboBox.Text;

        }

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {


            var password = PasswordName.Password;
            var money = Money.Text;

            CardNameError.Text = "";
            CreditCardNameError.Text = "";
            PasswordError.Text = "";
            MoneyError.Text = "";


            CheckPassword(password);
            CheckMoney(money);

            if (CheckPassword(password))
            {
                if (CheckMoney(money))
                {

                    var cards = db.Cards.ToList();



                    var card = cards.Find(item => item.CardName.Equals(cardName));

                    var creditCard = cards.Find(item => item.CardName.Equals(creditCardName) && item.TypeOfCard.Equals("Credit"));
                    if (card != null && card.BlockStatus.Equals(0))
                    {

                        db.Accounts.Load();
                        db.CreditAccs.Load();

                        var account = db.Accounts.Find(card.AccountId);

                        var creditAccList = db.CreditAccs.ToList();

                        var creditAcc = creditAccList.Find(item => item.CardId.Equals(creditCard.Id));

                        var creditAccount = db.CreditAccs.Find(creditAcc.Id);

                        if (account != null) account.Score -= moneyDouble;


                        if (creditAccount != null) creditAccount.Money -= moneyDouble;

                        if (creditAccount.Money < 0)
                        {
                            account.Score += Math.Abs(creditAccount.Money);

                            creditAccount.Money = 0;

                            db.SaveChanges();
                        }

                        var data = DateTime.Now.ToString();

                        var user = db.Users.Find(App.userNow);

                        var operation = new UserOperation(App.userNow, $"Pay credit for {money}$ ,use card {card.CardName} ", data);

                        db.UserOperations.Add(operation);

                        db.SaveChanges();
                        this.DialogResult = true;
                        this.Close();

                        var secOperation = new OutPutSec();

                        secOperation.ShowDialog();
                    }
                }
            }


        }

        public bool CheckPassword(string number)
        {
            _wrongInputValue = false;

            if (number.Length == 0)
            {
                PasswordError.Text = "Blank field";

                return false;
            }

            return true;
        }



        public bool CheckMoney(string money)
        {
            _wrongInputValue = false;

            _charString = money.ToCharArray();


            if (money.Length == 0)
            {
                MoneyError.Text = "Blank field";

                return false;
            }

            moneyDouble = double.Parse(money);

            return true;

        }



        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Money_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(
            object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 48; counter <= 57; counter++)
            {
                if (charVal == counter)
                {
                    _wrongInputValue = false;
                    break;
                }
                else
                {
                    _wrongInputValue = true;
                }
            }

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (Money.Text.Length > 100000000)
            {
                e.Handled = true;
            }
        }


        private void Password_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(
            object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 47; counter <= 57; counter++)
            {
                if (charVal == counter)
                {
                    _wrongInputValue = false;
                    break;
                }
                else
                {
                    _wrongInputValue = true;
                }
            }

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (PasswordName.Password.Length >= 4)
            {
                e.Handled = true;
            }
        }
    }
}