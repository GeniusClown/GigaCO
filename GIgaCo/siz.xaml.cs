using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GIgaCo
{
    /// <summary>
    /// Логика взаимодействия для siz.xaml
    /// </summary>
    public partial class siz : Page
    {
        public siz()
        {
            InitializeComponent();
            pdfWebViewer.Navigate(new Uri("https://compsch.com/obzor/texnika-bezopasnosti-pri-rabote-s-kompyuterom.html"));
        }

        private void silka(object sender, RoutedEventArgs e)
        {
            Process.Start("https://app.roboflow.com/farmmoney/cars-wvxqu/1");
        }
    }
}
