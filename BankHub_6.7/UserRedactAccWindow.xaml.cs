using Microsoft.EntityFrameworkCore;
using System;

using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BankHub_6._7
{
    /// <summary>
    /// Логика взаимодействия для UserRedactAccWindow.xaml
    /// </summary>
    public partial class UserRedactAccWindow
    {
        private ApplicationContext db;

        public UserRedactAccWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            User_Loaded();

            db.Users.Load();
        }

        private void Button_ClickChangePassword(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();

            Main.Opacity = 0;

            changePasswordWindow.ShowDialog();

            Main.Opacity = 1;
        }

        private void Button_ClickChangeData(object sender, RoutedEventArgs e)
        {
            ChangePersonalDataWindow changePersonalDataWindow = new ChangePersonalDataWindow();

           
            Main.Opacity =0;

            changePersonalDataWindow.ShowDialog();

            User_Loaded();

            Main.Opacity = 1;
        }

        private void User_Loaded()
        {
            db = new ApplicationContext();

            var user = db.Users.Find(App.userNow);

            if (user != null) NameTextBlock.Text = $"{user.Name}";

            if (user != null) LastNameTextBlock.Text = $"{user.LastName}";

            if (user != null) MailTextBlock.Text = $"{user.Mail}";

            if (user != null) PhoneTextBlock.Text = $"{user.Phone}";

            //if (user != null) UserImage.Background = new ImageBrush(new BitmapImage(
            //    new Uri($@"{user.Image}", UriKind.Relative)));
        }

        private void Button_BackToMenuClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            MainWindow mainWindow = new MainWindow();

           


            mainWindow.Show();

            

            this.Close();
        }

        private void Button_ClickChangePhoto(object sender, RoutedEventArgs e)
        {
            //AddPhoto add = new AddPhoto();

            //Main.Opacity = 0;

            //add.ShowDialog();

            //Main.Opacity = 1;
        }
    }
}
