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
    /// Логика взаимодействия для AddMoneyWindow.xaml
    /// </summary>
    public partial class AddMoneyWindow : Window
    {

        private bool _wrongInputValue;
        private char[] _charString;
        private int _cardId;
        private double moneyDouble;
        private string cardName;

        private ApplicationContext db;

        public AddMoneyWindow()
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

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {

            var password = PasswordName.Password;
            var money = Money.Text;

            CardNameError.Text = "";
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

                    if (card != null && card.BlockStatus == false)
                    {
                        db.Accounts.Load();

                        var account = db.Accounts.Find(card.AccountId);

                        if (account != null) account.Score += moneyDouble;

                        var data = DateTime.Now.ToString();

                        var user = db.Users.Find(App.userNow);

                        var operation = new UserOperation(App.userNow, $"Add {money}$ to account {account.AccountName} ,use card {card.CardName}", data);

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



        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
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

        //private void Name_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    char charVal = char.Parse(e.Text);

        //    for (int counter = 65; counter <= 122; counter++)
        //    {
        //        if (counter == 91 || counter == 92 || counter == 93 || counter == 94 || counter == 95 ||
        //            counter == 96)
        //        {
        //            continue;
        //        }

        //        if (charVal == counter)
        //        {
        //            _wrongInputValue = false;
        //            break;
        //        }
        //        else
        //        {
        //            _wrongInputValue = true;

        //        }
        //    }

        //    if (CardName.Text.Length > 15)
        //    {
        //        e.Handled = true;
        //    }


        //    if (_wrongInputValue)
        //    {
        //        e.Handled = true;
        //    }
        //}

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

            if (PasswordName.Password.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            //      CardName.Focus();

        }


    }
}
