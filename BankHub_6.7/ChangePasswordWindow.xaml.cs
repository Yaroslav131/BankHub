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
    /// Логика взаимодействия для ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow
    {
        private ApplicationContext db;

        private string _password;
        private string _repitePassword;

        public ChangePasswordWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            Password.Focus();

        }

        private void Button_ChangeClick(object sender, RoutedEventArgs e)
        {
            _password = Password.Password.Trim();
            _repitePassword = ReapeatPassword.Password.Trim();


            PasswordError.Text = "";
            RepiatePasswordError.Text = "";

            CheckPassword(_password, _repitePassword);


            if (!CheckPassword(_password, _repitePassword)) return;

            var user = db.Users.Find(App.userNow);

            if (user != null) user.Password = _password;

            db.SaveChanges();

            Close();

            var secOperation = new OutPutSec();

            secOperation.ShowDialog();
        }

        public bool CheckPassword(string password, string repeiadPassword)
        {
            _ = password.ToCharArray();

            if (password.Length == 0)
            {
                PasswordError.Text = "Blank field";

                if (repeiadPassword.Length == 0) RepiatePasswordError.Text = "Blank field";

                return false;
            }

            if (!password.Equals(repeiadPassword))
            {
                PasswordError.Text = "Password mismatch";

                return false;
            }

            return true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Password_OnPreviewTextInput_OnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Password.Password.Length >= 30)
            {
                e.Handled = true;
            }
        }

        private void Password2_OnPreviewTextInput_OnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (ReapeatPassword.Password.Length >= 30)
            {
                e.Handled = true;
            }
        }
    }
}