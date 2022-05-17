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
    /// Логика взаимодействия для GetCreditWindow.xaml
    /// </summary>
    public partial class GetCreditWindow : Window
    {
        private bool _wrongInputValue;
        private char[] _charString;
        private double moneyDouble;
        private double bankMoney;
        private string cardName;
        private ApplicationContext db;

        public GetCreditWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();

            var cards = db.Cards.ToList();

            var nameCardArray = new List<string>();

            for (int i = 0; i < cards.Count; i++)
            {

                if (cards[i].UserId.Equals(App.userNow) && cards[i].TypeOfCard.Equals("Credit"))
                {
                    nameCardArray.Add(cards[i].CardName);
                }
            }

            cardListComboBox.ItemsSource = nameCardArray;

            cardListComboBox.Focus();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            cardName = comboBox.SelectedItem.ToString();

        }

        public bool CheckPassword(string number)
        {

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



        private void Password_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(
            object sender, TextCompositionEventArgs e)
        {

            if (PasswordBox.Password.Length >= 4)
            {
                e.Handled = true;
            }

        }

        private void Data_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 48; counter <= 57; counter++)
            {
                if (charVal == counter || charVal == 45 || charVal == 46 || charVal == 47 || charVal == 58)
                {
                    _wrongInputValue = false;
                    break;
                }
                else
                {
                    _wrongInputValue = true;
                }
            }


            if (DataTextBox.Text.Length == 2)
            {
                if (charVal != 45 && charVal != 46 && charVal != 47 && charVal != 58)
                {
                    e.Handled = true;
                }
            }

            if (DataTextBox.Text.Length == 5)
            {
                if (charVal != 45 && charVal != 46 && charVal != 47 && charVal != 58)
                {
                    e.Handled = true;
                }
            }

            if (DataTextBox.Text.Length == 10)
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

            if (MoneyTextBox.Text.Length > 100000000)
            {
                e.Handled = true;
            }

            if (_wrongInputValue)
            {
                e.Handled = true;
            }
        }

        private bool CheckData(string data)
        {
            if (data.Length == 0)
            {
                DataError.Text = "Blank field";

                return false;
            }

            if (int.Parse(data) > 600)
            {
                DataError.Text = "Long term";

                return false;
            }


            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var password = PasswordBox.Password;
            var data = DataTextBox.Text;
            var money = MoneyTextBox.Text;

            CardNameError.Text = "";
            CardNameError.Text = "";
            PasswordError.Text = "";
            DataError.Text = "";
            MoneyError.Text = "";



            CheckMoney(money);
            CheckPassword(password);
            CheckData(data);


            if (CheckPassword(password))
            {
                if (CheckMoney(money))
                {
                    if (CheckData(data))
                    {

                        var cards = db.Cards.ToList();


                        var card = cards.Find(item => item.CardName.Equals(cardName));

                        if (card == null)
                        {
                            CardNameError.Text = "Unknown card";
                            return;

                        }

                        if (card.BlockStatus.Equals(1))
                        {
                            CardNameError.Text = "Card blocked";
                            return;

                        }

                        if (!card.Password.Equals(password))
                        {
                            PasswordError.Text = "Wrong password";

                            return;
                        }

                        if (card.CreditStatus.Equals(true))
                        {
                            CardNameError.Text = "Card have unpaid loan";

                            return;
                        }


                        var doubleMoney = double.Parse(money);

                        var bankMoney = db.BankSeting.First();

                        if (bankMoney.Score - doubleMoney > 0)
                        {
                            bankMoney.Score -= doubleMoney;
                        }
                        else
                        {
                            MoneyError.Text = "Bank doesn't have money now";

                            return;
                        }

                        var totaalSum = doubleMoney + (db.BankSeting.First().CreditPerCent / doubleMoney);

                        var account = db.Accounts.Find(card.AccountId);


                        account.Score += doubleMoney;

                        var dataStart = DateTime.UtcNow;
                        var dataEnd = dataStart.AddMonths(int.Parse(data));

                        var dataEndString = dataEnd.ToString();

                        var dataStartString = dataStart.ToString();

                        CreditAcc creditAcc = new CreditAcc(dataStartString, card.CardName, dataEndString,
                        db.BankSeting.First().CreditPerCent, App.userNow, card.Id, totaalSum);

                        db.CreditAccs.Add(creditAcc);

                        var user = db.Users.Find(App.userNow);

                        var operation = new UserOperation(App.userNow, $"Get credit for {money}$ use credit card {card.CardName}", dataStart.ToString());

                        db.UserOperations.Add(operation);

                        db.SaveChanges();

                        Credit.FactorialAsync(creditAcc);

                        this.Close();

                        var secOperation = new OutPutSec();

                        secOperation.ShowDialog();

                    }
                }

            }

        }
    }
}