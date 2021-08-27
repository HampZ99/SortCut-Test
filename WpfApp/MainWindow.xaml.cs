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

namespace WpfApp
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

        private void CTRLC_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hej");
        }

        private void CTRLV_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CTRLZ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CTRLY_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CTRLX_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
