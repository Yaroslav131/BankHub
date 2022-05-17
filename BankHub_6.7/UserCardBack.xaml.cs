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
    /// Логика взаимодействия для UserCardBack.xaml
    /// </summary>
    public partial class UserCardBack : Window
    {
        public UserCardBack(Card card)
        {
            InitializeComponent();

            CardNum1.Text = card.MainNumber.Substring(0, card.MainNumber.Length - 12);
            CardNum2.Text = card.MainNumber.Substring(4, card.MainNumber.Length - 12);
            CardNum3.Text = card.MainNumber.Substring(8, card.MainNumber.Length - 12);
            CardNum4.Text = card.MainNumber.Substring(12, card.MainNumber.Length - 12);

            CardData.Text = card.BestBeforeDate;
            CardCvc.Text = card.Cvc.ToString();
            CardPassword.Text = card.Password.ToString();
        }
    }
}
