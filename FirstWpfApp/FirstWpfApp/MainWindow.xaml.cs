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
using FirstWpfApp.ViewModels;

namespace FirstWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private void RegCalcButt_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Calculator();
        }

        private void CalendarButt_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModels.Calendar();
        }

        private void CurrConvButt_clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Converter();
        }
    }
}
