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
    /// Логика взаимодействия для CheckPassword.xaml
    /// </summary>
    public partial class CheckPassword : Window
    {
        private ApplicationContext _db;
        public CheckPassword()
        {
            InitializeComponent();
            _db = new ApplicationContext();
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            Password.Focus();

        }

        private void Button_CheckClick(object sender, RoutedEventArgs e)
        {

            PasswordError.Text = "";

            string password = Password.Password;

            CheckPasswords(password);


            var users = _db.Users.ToList();

            var user = users.Find(item => item.Id.Equals(App.userNow));

            if (CheckPasswords(password))
            {
                if (Password.Password != user.Password) return;
                DialogResult = true;

                this.Close();
            }

        }

        private void Password_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (Password.Password.Length >= 30)
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

        public bool CheckPasswords(string password)
        {
            _ = password.ToCharArray();

            if (password.Length == 0)
            {
                PasswordError.Text = "Blank field";

                return false;
            }


            return true;
        }
    }
}
