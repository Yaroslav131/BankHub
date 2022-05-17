using BankHub_6._0;
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
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        private readonly ApplicationContext _db;

        private string _login;
        private string _password;
        private bool _wrongInputValue;
        public SignInWindow()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }

        private void Button_SIngInClick(object sender, RoutedEventArgs e)
        {
            _login = LoginTextbox.Text;
            _password = PasswordTextbox.Password;

            var users = _db.Users.ToList();

            var user = users.Find(item => item.Mail.Equals(_login)) ?? users.Find(item => item.Phone.Equals(_login));

            LoginError.Text = "";
            PasswordError.Text = "";

            if (_password.Length == 0) PasswordError.Text = "Blank field";

            if (user == null)
            {
                LoginError.Text = "Unknown login";
            }
            else
            {
                if (user.Password.Equals(_password))
                {
                    if (user.BlockStatus == true) LoginError.Text = "User was blocked";

                    DialogResult = true;
                   
                    App.userNow = user.Id;

                    Close();
                }
                else
                {
                    PasswordError.Text = "Wrong password";
                }
            }
        }

        private void SignInWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            LoginTextbox.Focus();
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var charVal = char.Parse(e.Text);

            for (var counter = 46; counter <= 122; counter++)
            {
                if (charVal == 47 || counter == 91 || counter == 92 || counter == 93 || counter == 94 ||
                    counter == 95 || counter == 96) continue;

                if (charVal == counter || charVal == 64 || charVal == 43)
                {
                    _wrongInputValue = false;
                    break;
                }

                _wrongInputValue = true;

                if (counter == 57) counter = 64;
            }

            if (_wrongInputValue) e.Handled = true;


            if (LoginTextbox.Text.Length >= 30) e.Handled = true;
        }

        private void Password_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (LoginTextbox.Text.Length >= 30) e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }
    }
}