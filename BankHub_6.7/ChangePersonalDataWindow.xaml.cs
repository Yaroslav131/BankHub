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
    /// Логика взаимодействия для ChangePersonalDataWindow.xaml
    /// </summary>
    public partial class ChangePersonalDataWindow
    {
        private ApplicationContext db;

        private string _name;
        private string _lastName;
        private string _mail;
        private string _phone;
        private bool _wrongInputValue;
        private char[] _charString;
        private string _substringString;

        public ChangePersonalDataWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            db.Users.Load();

            User user;

            user = db.Users.Find(App.userNow);

            if (user != null)
            {
                NameTextBox.Text = user.Name;
                LastNameTextBox.Text = user.LastName;
                MailTextBox.Text = user.Mail;
                PhoneTextBox.Text = user.Phone;
            }
        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            NameTextBox.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _name = NameTextBox.Text.Trim();
            _lastName = LastNameTextBox.Text.Trim();
            _mail = MailTextBox.Text.Trim();
            _phone = PhoneTextBox.Text.Trim();

            NameError.Text = "";
            LastNameError.Text = "";
            MailError.Text = "";
            PhoneError.Text = "";

            CheckName(_name);
            CheckLastName(_lastName);
            CheckMail(_mail);
            CheckPhone(_phone);

            if (!CheckLastName(_lastName)) return;
            if (!CheckName(_name)) return;
            if (!CheckMail(_mail)) return;
            if (!CheckPhone(_phone)) return;
            User user = db.Users.Find(App.userNow);

            user.Name = _name;
            user.LastName = _lastName;
            user.Mail = _mail;
            user.Phone = _phone;

            db.SaveChanges();
            this.DialogResult = true;
            this.Close();
        }

        public bool CheckPhone(string phone)
        {
            _wrongInputValue = false;

            _charString = phone.ToCharArray();



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
                      .Equals("+37529") || _substringString.Equals("+37544") || _substringString.Equals("+37533") || _substringString.Equals("+37525"))
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
                      .Equals("@gmail.com") || mail.Substring(mail.Length - 9).Equals("@email.ru") || mail.Substring(mail.Length - 10).Equals("@yandex.ru")))
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
            else if (name.Length == 1)
            {
                NameError.Text = "Short name";

                return false;
            }
            else if (name.Length > 15)
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
            else if (lastName.Length == 1)
            {
                LastNameError.Text = "Short last name";

                return false;
            }
            else if (lastName.Length > 15)
            {
                LastNameError.Text = "Long last name";

                return false;
            }

            return true;
        }

        private void Name_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (NameTextBox.Text.Length > 20)
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


        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 48; counter <= 57; counter++)
            {
                if (counter == 47)
                {
                    continue;
                }

                if (charVal == counter || charVal == 43)
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

            if (NameTextBox.Text.Length >= 13)
            {
                e.Handled = true;
            }

        }



        private void Mail_OnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);


            for (int counter = 46; counter <= 122; counter++)
            {
                if (counter == 47 || counter == 91 || counter == 92 || counter == 93 || counter == 94 ||
                    counter == 95 || counter == 96)
                {
                    continue;
                }

                if (charVal == counter || charVal == 64)
                {
                    _wrongInputValue = false;
                    break;
                }
                else
                {
                    _wrongInputValue = true;
                }

                if (counter == 57)
                {
                    counter = 64;
                }
            }

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (NameTextBox.Text.Length > 25)
            {
                e.Handled = true;
            }

        }
    }
}
