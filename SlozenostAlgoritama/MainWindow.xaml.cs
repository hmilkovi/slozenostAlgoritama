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

namespace SlozenostAlgoritama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void Izracunaj(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("Pages/fibonaci.xaml", UriKind.Relative));
        }

        private void fakt(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("Pages/faktorijel.xaml", UriKind.Relative));
        }

        private void poc(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("Pages/Pocetna.xaml", UriKind.Relative));
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate(new Uri("Pages/Pocetna.xaml", UriKind.Relative));
        }
    }
}
