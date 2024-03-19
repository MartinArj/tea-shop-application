using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace tea_shop_app
{
    /// <summary>
    /// Interaction logic for add.xaml
    /// </summary>
    public partial class add : Page
    {
      
        Product_repository product = new Product_repository();
        private DispatcherTimer timer;
        public add()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Hide the TextBlock
            pname.Text = null;
            price.Text = null;
            message.Visibility = Visibility.Hidden ;

            // Stop the timer
            timer.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            product.addproduct(pname.Text, Convert.ToSingle(price.Text));
           
            message.Text = "product name:" + pname.Text + ",price:" + price.Text + ",inserted.";
            message.Visibility = Visibility.Visible;
            timer.Start();
          


        }

       
    }
}
