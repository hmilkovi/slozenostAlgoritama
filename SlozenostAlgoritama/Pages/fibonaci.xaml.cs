using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Numerics;
using System.Diagnostics;
using System.Threading;

namespace SlozenostAlgoritama.Pages
{
    /// <summary>
    /// Interaction logic for fibonaci.xaml
    /// </summary>
    public partial class fibonaci : Page
    {
        public fibonaci()
        {
            InitializeComponent();
        }
        
        private BigInteger Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }


        private void izraacun()
        {
            int i = 0;
            BrojOkr.Text = BrojNizracun.Text = "";
            int broj = (Int32)Convert.ToInt32(BrojN.Text);
            for (; i < broj; i++)
            {
                BrojNizracun.Text += Fibonacci(i).ToString() + ", ";
                BrojOkr.Text = (i+2).ToString();
            }
        }

        private void Izracun_Click(object sender, RoutedEventArgs e)
        {
            BrojNizracun.Text = "";
            izraacun();
        }
    }
}
