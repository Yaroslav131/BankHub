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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankHub_6._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignIn_OnClick(object sender, RoutedEventArgs e)
        {
            var singInWindow = new SignInWindow();

            var userMenu = new UserMenu();

            ContentGrid.Visibility = Visibility.Hidden;

            singInWindow.ShowDialog();

            if (singInWindow.DialogResult == true)
            {
                userMenu.Show();


                Close();
            }
            else
            {
                ContentGrid.Visibility = Visibility.Visible;
            }
        }

        private void SignUp_OnClick(object sender, RoutedEventArgs e)
        {
            var signUpWindow = new SignUpWindow();

            var userMenu = new UserMenu();

            ContentGrid.Visibility = Visibility.Hidden;

            signUpWindow.ShowDialog();

            if (signUpWindow.DialogResult == true)
            {
                userMenu.Show();


                Close();
            }
            else
            {
                ContentGrid.Visibility = Visibility.Visible;
            }
        }

        private void Button_GoOutClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

            Close();
        }
    }
}