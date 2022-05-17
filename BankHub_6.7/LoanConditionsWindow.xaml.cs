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
    /// Логика взаимодействия для LoanConditionsWindow.xaml
    /// </summary>
    public partial class LoanConditionsWindow : Window
    {
        public LoanConditionsWindow()
        {
            InitializeComponent();
        }

        private void AcceptClick(object sender, RoutedEventArgs e)
        {
            if (Accept.IsChecked == true)
            {
                GetCreditWindow creditWindow = new GetCreditWindow();

                this.Close();

                creditWindow.ShowDialog();


            }
        }

        private void Accept_OnClick(object sender, RoutedEventArgs e)
        {
            if (Accept.IsChecked == true)
            {
                Continue.Opacity = 1;
            }

            if (Accept.IsChecked == false)
            {
                Continue.Opacity = 0.5;
            }
        }

        private void Accept_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
