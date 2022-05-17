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
    /// Логика взаимодействия для DeleteAccWindow.xaml
    /// </summary>
    public partial class DeleteAccWindow
    {
        private readonly ApplicationContext _db;

        private string _name;
        private bool _wrongInputValue;
        private char[] _charString;
        private int accountId;

        public DeleteAccWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            NameTextBox.Focus();

        }

        private void Button_DeleteClick(object sender, RoutedEventArgs e)
        {
            _name = NameTextBox.Text.Trim();

            NameError.Text = "";

            CheckName(_name, ref accountId);

            if (CheckName(_name, ref accountId))
            {
                var cards = _db.Cards.ToList();

                var userCards = cards.FindAll(item => item.AccountId.Equals(accountId - 1));

                foreach (var card in userCards)
                {
                    _db.Cards.Remove(card);
                }

                var account = _db.Accounts.Find(accountId);

                if (account != null) _db.Accounts.Remove(account);

                _db.SaveChanges();

                DialogResult = true;

                Close();

                var secOperation = new OutPutSec();

                secOperation.ShowDialog();
            }
        }

        public bool CheckName(string name, ref int accountId)
        {
            _wrongInputValue = false;

            _charString = name.ToCharArray();


            var accounts = _db.Accounts.ToList();

            foreach (var t in accounts)
                if (t.AccountName.Equals(name))
                {
                    accountId = t.Id;
                    _wrongInputValue = false;
                    return true;
                }
                else
                {
                    _wrongInputValue = true;
                }


            if (_wrongInputValue)
            {
                NameError.Text = "Unknown account";
                return false;
            }

            if (name.Length != 0) return true;
            NameError.Text = "Blank field";

            return false;
        }

        private void Name_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (int counter = 65; counter <= 122; counter++)
            {
                if (counter == 91 || counter == 92 || counter == 93 || counter == 94 || counter == 95 ||
                    counter == 96)
                {
                    continue;
                }

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

            if (NameTextBox.Text.Length > 15)
            {
                e.Handled = true;
            }


            if (_wrongInputValue)
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

    }
}