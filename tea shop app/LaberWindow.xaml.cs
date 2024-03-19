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

namespace tea_shop_app
{
    /// <summary>
    /// Interaction logic for LaberWindow.xaml
    /// </summary>
    public partial class LaberWindow : Window
    {
        public LaberWindow()
        {
            InitializeComponent();
            laberpage.NavigationService.Navigate(new OrderPage());
            
        }

        private void order_btn_Click_1(object sender, RoutedEventArgs e)
        {
            laberpage.NavigationService.Navigate(new OrderPage());
        }

        private void find_btn_Click_1(object sender, RoutedEventArgs e)
        {
            laberpage.NavigationService.Navigate(new FindBillPage());
        }

        private void log_out_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow op = new MainWindow();
            op.Show();
            this.Close();
        }

        private void product_Click_1(object sender, RoutedEventArgs e)
        {
            laberpage.NavigationService.Navigate(new view());
        }

      
    }
}
