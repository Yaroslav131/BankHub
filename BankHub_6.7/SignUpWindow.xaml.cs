using BankHub_6._0;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для SignUpWindow.xaml
    /// </summary>
   public partial class SignUpWindow
    {
        private readonly ApplicationContext db;

        private string _name;
        private string _lastName;
        private string _mail;
        private string _phone;
        private string _password;
        private string _repitePassword;
        private string _image;
        private bool _wrongInputValue;
        private char[] _charString;
        private string _substringString;

        private List<User> _usersList;

        public SignUpWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is bool && values[1] is bool)
            {
                var hasText = !(bool)values[0];
                var hasFocus = (bool)values[1];

                if (hasFocus || hasText)
                    return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private void Button_RegClick(object sender, RoutedEventArgs e)
        {
            _name = NameTextBox.Text.Trim();
            _lastName = LastNameTextBox.Text.Trim();
            _mail = MailTextBox.Text.Trim();
            _phone = PhoneTextBox.Text.Trim();
            _password = PasswordBox.Password.Trim();
            _repitePassword = RepitPasswordBox.Password.Trim();
            _image = "D:\\.NET\\BankHub_5.0\\BankHub_5.0\\Image\\user1.png";

            NameError.Text = "";
            LastNameError.Text = "";
            MailError.Text = "";
            PhoneError.Text = "";
            PasswordError.Text = "";
            RepiatePasswordError.Text = "";

            CheckName(_name);
            CheckLastName(_lastName);
            CheckMail(_mail);
            CheckPhone(_phone);
            CheckPassword(_password, _repitePassword);

            if (CheckLastName(_lastName))
                if (CheckName(_name))
                    if (CheckMail(_mail))
                        if (CheckPhone(_phone))
                            if (CheckPassword(_password, _repitePassword))
                            {
                                var user = new User(_name, _lastName, _mail, _phone, _password, _image);

                                db.Users.Add(user);

                                db.SaveChanges();

                                App.userNow = user.Id;


                                DialogResult = true;

                                Close();
                            }
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

        public bool CheckPhone(string phone)
        {
            _wrongInputValue = false;

            _charString = phone.ToCharArray();

            _usersList = db.Users.ToList();

            if (_usersList.Any(user => user.Phone.Equals(phone)))
            {
                PhoneError.Text = "This number is already in use";

                return false;
            }


            if (phone.Length == 0)
            {
                PhoneError.Text = "Blank field";

                return false;
            }

            if (_charString.Length != 13)
            {
                PhoneError.Text = "Invalid number";

                return false;
            }

            _substringString = phone.Substring(0, phone.Length - 7);
            if (!_substringString
                    .Equals("+37529") || _substringString.Equals("+37544") || _substringString.Equals("+37533") ||
                _substringString.Equals("+37525"))
            {
                PhoneError.Text = "Unknown phone code";

                return false;
            }

            if (_charString[0] != 43)
            {
                PhoneError.Text = "Invalid number";

                return false;
            }

            return true;
        }

        public bool CheckMail(string mail)
        {
            _wrongInputValue = false;

            _charString = mail.ToCharArray();

            _usersList = db.Users.ToList();

            foreach (var user in _usersList)
                if (user.Mail.Equals(_mail))
                {
                    MailError.Text = "This mail is already in use";

                    return false;
                }

            if (mail.Length == 0)
            {
                MailError.Text = "Blank field";

                return false;
            }

            if (mail.Length < 9)
            {
                MailError.Text = "Short mail";

                return false;
            }

            if (!(mail.Substring(mail.Length - 10)
                      .Equals("@gmail.com") || mail.Substring(mail.Length - 9).Equals("@email.ru") ||
                  mail.Substring(mail.Length - 10).Equals("@yandex.ru")))
            {
                MailError.Text = "Unknown mail extension";

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

        public bool CheckLastName(string lastName)
        {
            _wrongInputValue = false;

            _charString = lastName.ToCharArray();


            if (lastName.Length == 0)
            {
                LastNameError.Text = "Blank field";

                return false;
            }

            if (lastName.Length == 1)
            {
                LastNameError.Text = "Short last name";

                return false;
            }

            if (lastName.Length > 15)
            {
                LastNameError.Text = "Long last name";

                return false;
            }

            return true;
        }

        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var charVal = char.Parse(e.Text);

            for (var counter = 48; counter <= 57; counter++)
            {
                if (counter == 47) continue;

                if (charVal == counter || charVal == 43)
                {
                    _wrongInputValue = false;
                    break;
                }

                _wrongInputValue = true;
            }


            if (PhoneTextBox.Text.Length >= 13) e.Handled = true;

            if (_wrongInputValue) e.Handled = true;
        }


        private void Mail_OnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var charVal = char.Parse(e.Text);


            for (var counter = 46; counter <= 122; counter++)
            {
                if (counter == 47 || counter == 91 || counter == 92 || counter == 93 || counter == 94 ||
                    counter == 95 || counter == 96)
                    continue;

                if (charVal == counter || charVal == 64)
                {
                    _wrongInputValue = false;
                    break;
                }

                _wrongInputValue = true;

                if (counter == 57) counter = 64;
            }

            if (MailTextBox.Text.Length >= 30) e.Handled = true;

            if (_wrongInputValue) e.Handled = true;
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

            if (NameTextBox.Text.Length > 15) e.Handled = true;


            if (_wrongInputValue) e.Handled = true;
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space) e.Handled = true;
        }

        private void Password_OnPreviewTextInput_OnPreviewTextInputTextBox_PreviewTextInput(object sender,
            TextCompositionEventArgs e)
        {
            if (PasswordBox.Password.Length >= 30) e.Handled = true;
        }


        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            NameTextBox.Focus();
        }
    }
}