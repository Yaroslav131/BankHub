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
    /// Логика взаимодействия для LastOperation.xaml
    /// </summary>
    public partial class LastOperation : Window
    {
        private ApplicationContext db;
        public LastOperation()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.UserOperations.Load();
            this.DataContext = db.UserOperations.Local.ToBindingList();
        }

        private void ReportClick(object sender, RoutedEventArgs e)
        {
            var report = new MakeReport();


            this.Opacity = 0;

            report.ShowDialog();

            this.Opacity = 1;

            this.Close();

            var secOper = new OutPutSec();

            secOper.ShowDialog();
        }
    }
}
