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
    /// Логика взаимодействия для TransitMoneyToOhterAccountWindow.xaml
    /// </summary>
    public partial class TransitMoneyToOhterAccountWindow
    {
        private bool _wrongInputValue;
        private char[] _charString;
        private int _cardId;
        private double moneyDouble;
        private string cardName;


        private readonly ApplicationContext db;
        public TransitMoneyToOhterAccountWindow()
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

            cardList.ItemsSource = nameCardArray;

            cardList.Focus();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            cardName = comboBox.SelectedItem.ToString();

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }



        private void CardNum1_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (CardNum1.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void CardNum2_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (CardNum2.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }



        private void CardNum3_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (CardNum3.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void CardNum4_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (CardNum4.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void Money_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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



        private void Password_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (CardPassword.Password.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void TransitClick(object sender, RoutedEventArgs e)
        {

            NameError.Text = "";
            CardNameError.Text = "";
            MoneyError.Text = "";
            PasswordError.Text = "";


            var password = CardPassword.Password;
            var money = Money.Text;
            var userNumber = $"{CardNum1.Text}{CardNum2.Text}{CardNum3.Text}{CardNum4.Text}";



            CheckPassword(password);
            CheckMoney(money);

            if (!CheckNumber(userNumber)) return;

            if (!CheckPassword(password)) return;
            if (!CheckMoney(money)) return;

            var cards = db.Cards.ToList();

            var card = cards.Find(item => item.CardName.Equals(cardName));

            var cardRecp = cards.Find(item => item.MainNumber.Equals(userNumber));

            if (card == null && cardRecp.BlockStatus.Equals(1)) return;
            if (cardRecp == null) return;

            db.Accounts.Load();

            var account = db.Accounts.Find(card.AccountId);
            var accountRecp = db.Accounts.Find(cardRecp.AccountId);

            if (account != null && account.Score - moneyDouble < 0)
            {
                MoneyError.Text = "Not enough money";

                if (card.TypeOfCard == "Credit")
                {
                    OfferLoan loan = new OfferLoan();

                    this.Opacity = 0;

                    loan.ShowDialog();

                    this.Opacity = 1;

                }
                else
                {
                    OfferLoan2 loan2 = new OfferLoan2();

                    this.Opacity = 0;

                    loan2.ShowDialog();


                    this.Opacity = 1;
                }
            }
            else
            {
                if (account != null) account.Score -= moneyDouble;
                if (accountRecp != null) accountRecp.Score += moneyDouble;

                var data = DateTime.Now.ToString();

                var userRecp = db.Users.Find(cardRecp.UserId);

                var operation = new UserOperation(App.userNow, $"Transit {money}$ from account {account.AccountName}, use card {card.CardName},  to {userRecp.Name} {userRecp.LastName}  number card {cardRecp.MainNumber}", data);

                db.UserOperations.Add(operation);

                db.SaveChanges();
                this.DialogResult = true;
                this.Close();

                var secOperation = new OutPutSec();

                secOperation.ShowDialog();
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

        public bool CheckName(string name)
        {
            _wrongInputValue = false;

            _charString = name.ToCharArray();


            if (name.Length == 0)
            {
                CardNameError.Text = "Blank field";

                return false;
            }
            else if (name.Length == 1)
            {
                CardNameError.Text = "Short name";

                return false;
            }
            else if (name.Length > 15)
            {
                CardNameError.Text = "Long name";

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

        public bool CheckNumber(string number)
        {
            _wrongInputValue = false;

            _charString = number.ToCharArray();


            if (_wrongInputValue)
            {
                NameError.Text = "Invalid symbols";

                return false;
            }

            if (number.Length == 0)
            {
                NameError.Text = "Blank field";

                return false;
            }

            return true;
        }

    }
}
