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
    /// Логика взаимодействия для OfferLoan.xaml
    /// </summary>
    public partial class OfferLoan : Window
    {
        public OfferLoan()
        {
            InitializeComponent();
        }

        private void Button_YesClick(object sender, RoutedEventArgs e)
        {
            LoanConditionsWindow conditionsWindow = new LoanConditionsWindow();

            this.Opacity = 0;

            conditionsWindow.ShowDialog();

            this.Opacity = 1;

            this.Close();
        }
    }
}
