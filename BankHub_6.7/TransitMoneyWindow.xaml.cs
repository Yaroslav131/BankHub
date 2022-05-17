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
    /// Логика взаимодействия для TransitMoneyWindow.xaml
    /// </summary>
    public partial class TransitMoneyWindow : Window
    {
        private string _name;
        private string _recpName;
        private bool _wrongInputValue;
        private char[] _charString;
        private double moneyDouble;
        private string _money;
        private string accName;
        private string accRecName;

        private ApplicationContext db;

        public TransitMoneyWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            var accounts = db.Accounts.ToList();

            var nameAccountsArray = new List<string>();

            for (int i = 0; i < accounts.Count; i++)
            {

                if (accounts[i].UserId.Equals(App.userNow))
                {
                    nameAccountsArray.Add(accounts[i].AccountName);
                }
            }

            accList.ItemsSource = nameAccountsArray;

            accList.Focus();
        }

        private void ComboBoxAcc_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            accName = comboBox.SelectedItem.ToString();

        }

        private void ComboBoxAccRec_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;


            accRecName = comboBox.SelectedItem.ToString();

        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _money = Money.Text;

            AccError.Text = "";
            AccRecListError.Text = "";
            MoneyError.Text = "";


            if (CheckMoney(_money))
            {

                db.Accounts.Load();

                var accounts = db.Accounts.ToList();

                var accountId = accounts.Find(item => item.AccountName.Equals(_name)).Id;



                var accountIdRecp = accounts.Find(item => item.AccountName.Equals(_recpName)).Id;


                if (accounts.Find(item => item.Id.Equals(accountId)).Score - moneyDouble < 0)
                {
                    MoneyError.Text = "Not enough money";

                }
                else
                {
                    var account = accounts.Find(item => item.Id.Equals(accountId));

                    var accountRecp = accounts.Find(item => item.Id.Equals(accountIdRecp));

                    account.Score -= moneyDouble;

                    accountRecp.Score += moneyDouble;

                    var data = DateTime.Now.ToString();

                    var user = db.Users.Find(App.userNow);

                    var operation = new UserOperation(App.userNow, $"Transit {_money}$ from account {account.AccountName} to account {accountRecp.AccountName} ", data);

                    db.UserOperations.Add(operation);


                    db.SaveChanges();
                    this.DialogResult = true;
                    this.Close();

                    var secOperation = new OutPutSec();

                    secOperation.ShowDialog();
                }
            }


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

            if (Money.Text.Length > 100000000)
            {
                e.Handled = true;
            }

            if (_wrongInputValue)
            {
                e.Handled = true;
            }
        }
    }
}