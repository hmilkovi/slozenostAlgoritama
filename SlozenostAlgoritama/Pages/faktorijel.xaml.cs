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
using System.Numerics;

namespace SlozenostAlgoritama.Pages
{
    /// <summary>
    /// Interaction logic for faktorijel.xaml
    /// </summary>
    public partial class faktorijel : Page
    {
        public faktorijel()
        {
            InitializeComponent();
        }

        private BigInteger okretaj = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            okretaj = 0;
            int br = (Int32)Convert.ToInt32(brojN.Text);
            fakorijel.Text = Factorial(br).ToString();
            BrojOkr.Text = (okretaj-1).ToString();
        }

        BigInteger Factorial(int n)
        {
            okretaj++;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    }
}
