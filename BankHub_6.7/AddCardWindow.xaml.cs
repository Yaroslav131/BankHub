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
    /// Логика взаимодействия для AddCardWindow.xaml
    /// </summary>
    public partial class AddCardWindow : Window
    {
        private string _typeCard;
        private readonly ApplicationContext _db;

        private string _accName;
        private string _cardName;
        private bool _wrongInputValue;
        private char[] _charString;

        private string _number;
        private string _data;
        private string _cvc;

        private string _password;

        public AddCardWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            AccName.Focus();
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            var tvItem = (TreeViewItem)sender;

            _typeCard = tvItem.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _accName = AccName.Text.Trim();
            _cardName = CardName.Text.Trim();

            TyepError.Text = "";
            AccName.Text = "";
            CardName.Text = "";

            CheckAccName(_accName);
            CheckCardName(_cardName);
            CheckType(_typeCard);

            if (CheckAccName(_accName))
                if (CheckCardName(_cardName))
                    if (CheckType(_typeCard))
                    {
                        _db.Accounts.Load();

                        var accounts = _db.Accounts.ToList();

                        var account = accounts.Find(item => item.AccountName.Equals(_accName));

                        var accountId = account.Id;

                        GenerationCard();
                      
                        var card = new Card(accountId, App.userNow, _typeCard, _number, _cvc, _data, _password,
                            _cardName);

                        _db.Cards.Add(card);

                        _db.SaveChanges();

                        DialogResult = true;

                        var cardBack = new UserCardBack(card);

                        cardBack.ShowDialog();

                        Close();

                        var secOperation = new OutPutSec();

                        secOperation.ShowDialog();
                    }
        }

        public bool CheckType(string _typeCard)
        {
            if (_typeCard == null)
            {
                TyepError.Text = "Choose type of card";
                return false;
            }

            return true;
        }

        public bool CheckAccName(string name)
        {
            _wrongInputValue = false;

            _charString = name.ToCharArray();

            var accounts = _db.Accounts.ToList();

            var userAccounts = accounts.Where(account => account.UserId == App.userNow).ToList();

            var accountNow = userAccounts.Find(item => item.AccountName.Equals(_accName));

            if (accountNow == null)
            {
                AccNameError.Text = "Unknown name";

                return false;
            }


            if (name.Length == 0)
            {
                AccNameError.Text = "Blank field";

                return false;
            }

            if (name.Length == 1)
            {
                AccNameError.Text = "Short name";

                return false;
            }

            if (name.Length > 15)
            {
                AccNameError.Text = "Long name";

                return false;
            }

            return true;
        }

        public bool CheckCardName(string name)
        {
            _wrongInputValue = false;

            _charString = name.ToCharArray();

            for (var i = 0; i < _charString.Length; i++)
            {
                for (var counter = 65; counter < 122; counter++)
                {
                    if (counter == 91 || counter == 92 || counter == 93 || counter == 94 || counter == 95 ||
                        counter == 96) continue;

                    if (_charString[i] == counter)
                    {
                        _wrongInputValue = false;
                        break;
                    }

                    _wrongInputValue = true;
                }

                if (_wrongInputValue)
                {
                    CardNameError.Text = "Invalid symbols";

                    return false;
                }
            }

            if (name.Length == 0)
            {
                CardNameError.Text = "Blank field";

                return false;
            }

            if (name.Length == 1)
            {
                CardNameError.Text = "Short name";

                return false;
            }

            if (name.Length > 15)
            {
                CardNameError.Text = "Long name";

                return false;
            }

            return true;
        }

        private void GenerationCard()
        {
            var random = new Random();
            for (var i = 0; i < 16; i++) _number += random.Next(0, 9).ToString();

            for (var i = 0; i < 3; i++) _cvc += random.Next(0, 9).ToString();

            var now = DateTime.Now;
            _data = $"{now:dd}/{now:MM}";

            for (var i = 0; i < 4; i++) _password += random.Next(0, 9);
        }

        private void CardName_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            var charVal = char.Parse(e.Text);

            for (var counter = 65; counter <= 122; counter++)
            {
                if (counter == 91 || counter == 92 || counter == 93 || counter == 94 || counter == 95 ||
                    counter == 96)
                    continue;

                if (charVal == counter)
                {
                    _wrongInputValue = false;
                    break;
                }

                _wrongInputValue = true;
            }

            if (CardName.Text.Length > 15) e.Handled = true;

            if (_wrongInputValue) e.Handled = true;
        }

        private void AccName_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            var charVal = char.Parse(e.Text);

            for (var counter = 65; counter <= 122; counter++)
            {
                if (counter == 91 || counter == 92 || counter == 93 || counter == 94 || counter == 95 ||
                    counter == 96)
                    continue;

                if (charVal == counter)
                {
                    _wrongInputValue = false;
                    break;
                }

                _wrongInputValue = true;
            }

            if (AccName.Text.Length > 15) e.Handled = true;

            if (_wrongInputValue) e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }
    }
}
