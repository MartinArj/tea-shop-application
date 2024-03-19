using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
       
        public ManagerWindow()
        {
            InitializeComponent();
            manager.NavigationService.Navigate(new add());
          
        }
      

        private void Add_product(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new add());
          
        }

        private void Update_product(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new update());
        }

      
        private void view(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new view());
        }

        private void logout_btn_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void resource_Click_1(object sender, RoutedEventArgs e)
        {
            if (resource.IsChecked == true)
            {
                resource_pannel.Visibility = Visibility.Visible;
            }
            else
            {
                resource_pannel.Visibility = Visibility.Collapsed;
 
            }
        }

        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new addemployee());
        }

        private void remove_Click_1(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new remove_emp());
        }

        private void product_Click_1(object sender, RoutedEventArgs e)
        {
            if (product.IsChecked == true)
            {
                product_panal.Visibility = Visibility.Visible;
            }
            else
            {
                product_panal.Visibility = Visibility.Collapsed;
            }
        }

       

        private void emp_view_Click_1(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new view_emp());
        }

        
    }
}
