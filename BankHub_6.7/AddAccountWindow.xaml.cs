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
    /// Логика взаимодействия для AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        private readonly ApplicationContext db;

        private string _name;
        private bool _wrongInputValue;
        private char[] _charString;


        public AddAccountWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _name = Name.Text.Trim();

            NameError.Text = "";

            double _money = 0;

            CheckName(_name);

            if (CheckName(_name))
            {
                var account = new Account(_name, _money, App.userNow);

                db.Accounts.Add(account);

                db.SaveChanges();

                DialogResult = true;

                Close();

                var secOperation = new OutPutSec();

                secOperation.ShowDialog();
            }
        }

        public bool CheckName(string name)
        {
            _wrongInputValue = false;

            _charString = name.ToCharArray();

            var accList = db.Accounts.ToList();

            if (accList.Any(account => account.AccountName.Equals(name)))
            {
                NameError.Text = "This name is already in use";

                return false;
            }


            if (name.Length == 0)
            {
                NameError.Text = "Blank field";

                return false;
            }

            if (name.Length == 1)
            {
                NameError.Text = "Short name";

                return false;
            }

            if (name.Length > 15)
            {
                NameError.Text = "Long name";

                return false;
            }

            return true;
        }

        private void Name_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender,
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

            if (_wrongInputValue) e.Handled = true;

            if (Name.Text.Length > 15) e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Name.Focus();
        }
    }
}