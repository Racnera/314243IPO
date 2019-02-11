/* Ethan Hunter, 2/8/2019,  Takes two numbers and calculates area */
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal length;
            decimal width;
            decimal area;

            decimal.TryParse(txtLength.Text, out length);
            decimal.TryParse(txtWidth.Text, out width);

            area = length * width;
            output.Content = "The Area is: " + area.ToString("#.000");
        }
    }
}
