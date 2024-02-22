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
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }
        // public manager()
        //{
        //    InitializeComponent();
        //    manager.Navigate(new Uri("MAINWINDOW.XAML"));
        //   // this.NavigationService.Navigate(
        //}

        private void Add_product(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new add());
        }

        private void Update_product(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new update());
        }

        private void Delte(object sender, RoutedEventArgs e)
        {
            manager.NavigationService.Navigate(new delete());
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
    }
}
