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
    /// Логика взаимодействия для DeleteCardWindow.xaml
    /// </summary>
    public partial class DeleteCardWindow : IMultiValueConverter
    {
        private bool _wrongInputValue;
        private char[] _charString;
        private int _cardId;

        private ApplicationContext db;
        public DeleteCardWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

        }

        private void FocusWindow_OnLoaded(object sender, RoutedEventArgs e)
        {

            CardNum1TextBox.Focus();

        }

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Always test MultiValueConverter inputs for non-null
            // (to avoid crash bugs for views in the designer)
            if (values[0] is bool && values[1] is bool)
            {
                bool hasText = !(bool)values[0];
                bool hasFocus = (bool)values[1];

                if (hasFocus || hasText)
                    return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            string userNumber = $"{CardNum1TextBox.Text}{CardNum2TextBox.Text}{CardNum3TextBox.Text}{CardNum4TextBox.Text}";
            string userData = DataTextBox.Text;
            string userCvc = CardCvcTextBox.Text;
            string password = CardPasswordTextBox.Password;


            NameError.Text = "";
            DataError.Text = "";
            CvcError.Text = "";
            PasswordError.Text = "";

            CheckNumber(userNumber);
            CheckData(userData);
            CheckCvc(userCvc);
            CheckPassword(password);

            if (CheckNumber(userNumber))
            {
                if (CheckData(userData))
                {
                    if (CheckCvc(userCvc))
                    {
                        if (CheckPassword(password))
                        {
                            if (CheckCard(userNumber, userData, userCvc, password))
                            {

                                var card = db.Cards.Find(_cardId);

                                if (card != null && card.UserId.Equals(App.userNow))
                                {
                                    db.Cards.Remove(card);

                                    db.SaveChanges();

                                    this.DialogResult = true;

                                    this.Close();
                                    var secOperation = new OutPutSec();

                                    secOperation.ShowDialog();

                                }



                            }
                        }
                    }
                }
            }
        }

        public bool CheckCard(string number, string userData, string userCvc, string password)
        {
            var cards = db.Cards.ToList();

            foreach (var card in cards)
            {

                if (card.MainNumber.Equals(number))
                {
                    if (card.BestBeforeDate.Equals(userData))
                    {
                        if (card.Cvc.Equals(userCvc))
                        {
                            _cardId = card.Id;
                            _wrongInputValue = false;
                            return true;
                        }
                        else
                        {
                            _wrongInputValue = true;
                        }
                    }
                    else
                    {
                        _wrongInputValue = true;
                    }
                }
                else
                {
                    _wrongInputValue = true;
                }
            }

            if (_wrongInputValue)
            {
                CardError.Text = "Unknown card number";

                return false;
            }

            if (!password.Equals(cards[_cardId].Password))
            {
                PasswordError.Text = "Wrong password";
                return false;
            }

            return true;
        }

        public bool CheckNumber(string number)
        {
            _wrongInputValue = false;

            _charString = number.ToCharArray();


            if (_wrongInputValue)
            {
                NameError.Text = "Invalid symbols";

                return false;
            }

            if (number.Length == 0)
            {
                NameError.Text = "Blank field";

                return false;
            }

            return true;
        }

        public bool CheckData(string number)
        {
            _wrongInputValue = false;

            _charString = number.ToCharArray();


            if (_charString[2] != 47)
            {
                DataError.Text = "Wrong expression";

                return false;
            }

            if (number.Length == 0)
            {
                DataError.Text = "Blank field";

                return false;
            }

            return true;
        }

        public bool CheckPassword(string number)
        {
            _wrongInputValue = false;

            _charString = number.ToCharArray();


            if (number.Length == 0)
            {
                PasswordError.Text = "Blank field";

                return false;
            }

            return true;
        }

        public bool CheckCvc(string number)
        {
            _wrongInputValue = false;

            _charString = number.ToCharArray();

            if (number.Length == 0)
            {
                CvcError.Text = "Blank field";

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




        private void CardNum1_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardNum1TextBox.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void CardNum2_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardNum2TextBox.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void Cvc_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardCvcTextBox.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void CardNum3_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardNum3TextBox.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void CardNum4_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardNum4TextBox.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void Data_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 47; counter <= 57; counter++)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (DataTextBox.Text.Length >= 5)
            {
                e.Handled = true;
            }

        }

        private void Password_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char charVal = char.Parse(e.Text);

            for (var counter = 47; counter <= 57; counter++)
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

            if (_wrongInputValue)
            {
                e.Handled = true;
            }

            if (CardPasswordTextBox.Password.Length >= 4)
            {
                e.Handled = true;
            }
        }
    }
}
