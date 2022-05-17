using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MakeReport.xaml
    /// </summary>
    public partial class MakeReport : Window
    {
        private string _typeSearch;
        private readonly ApplicationContext _db;


        private bool _wrongInputValue;
        private char[] _charString;
        private string _substringString;


        public MakeReport()
        {
            InitializeComponent();

            _db = new ApplicationContext();
        }


        public bool CheckType(string _typeCard)
        {
            if (_typeCard == null)
            {
                TypeError.Text = "Choose period";
                return false;
            }

            return true;
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            var tvItem = (TreeViewItem)sender;

            _typeSearch = tvItem.Name;
        }

        private void MakeReport_Click(object sender, RoutedEventArgs e)
        {
            var user = _db.Users.Find(App.userNow);

            string path = @"D:\BankHub_6.7";
            string textReport = $"Report of {user.Name} {user.LastName} activite for {_typeSearch}:";

            if (CheckType(_typeSearch))
            {
                DateTime dataEnd = DateTime.UtcNow;
                DateTime dataStart = DateTime.UtcNow;

                List<UserOperation> ReportList = new List<UserOperation>();


                if (_typeSearch == "Day")
                {
                    dataStart = dataEnd.AddDays(-1);
                }
                else if (_typeSearch == "Month")
                {
                    dataStart = dataEnd.AddMonths(-1);
                }
                else if (_typeSearch == "Year")
                {
                    dataStart = dataEnd.AddYears(-1);
                }

                var operations = _db.UserOperations.ToList();




                for (int counter = 0; counter < operations.Count; counter++)
                {
                    var timeOperation = DateTime.Parse(operations[counter].Time);

                    if (timeOperation > dataStart && timeOperation < dataEnd)
                    {
                        ReportList.Add(operations[counter]);

                    }

                }

                foreach (var report in ReportList)
                {
                    textReport += $" \n {report.Type} \n {report.Time}";
                }

                DirectoryInfo dirInfo = new DirectoryInfo(path);

                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                string dataNowString = DateTime.Now.ToLongTimeString().ToString();
                using (FileStream fstream = new FileStream($@"{path}\report_{dataNowString}.txt", FileMode.OpenOrCreate))
                {
                    byte[] array = Encoding.Default.GetBytes(textReport);

                    fstream.Write(array, 0, array.Length);
                }

                this.Close();


            }
        }
    }
}
