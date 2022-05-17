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
    /// Логика взаимодействия для NewsWindow.xaml
    /// </summary>
    public partial class NewsWindow : Window
    {
        public NewsWindow()
        {
            InitializeComponent();
        }

        public void Browser_OnLoadCompleted(object sender, NavigationEventArgs e)
        {
            var browser = sender as WebBrowser;

            if (browser?.Document == null)
                return;

            dynamic document = browser.Document;

            if (document.readyState != "complete")
                return;

            var script = document.createElement("script");
            script.type = @"text/javascript";
            script.text = @"window.onerror = function(msg,url,line){return true;}";
            document.head.appendChild(script);
        }
    }
}


