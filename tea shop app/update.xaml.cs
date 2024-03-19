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
using System.Windows.Threading;

namespace tea_shop_app
{
    /// <summary>
    /// Interaction logic for update.xaml
    /// </summary>
    public partial class update : Page
    {
        private DispatcherTimer timer;
        string status = "";
        public update()
        {
            InitializeComponent();
            timer=new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
         
        }

        void timer_Tick(object sender, EventArgs e)
        {
            id.Text = null;
            old_name.Text = null;
            old_price.Text = null;
            old_status.Text = null;
            new_name.Text = null;
            new_price.Text = null;
            
            message.Visibility = Visibility.Hidden;
            message1.Visibility = Visibility.Hidden;
            timer.Stop();
        }
        Product_repository product = new Product_repository();
        string pname = "";
        float price = 0;
        private void update_btn(object sender, RoutedEventArgs e)
        {
            if (new_name.Text == "")
            {
                new_name.Text = pname;
            }
            if (new_price.Text =="")
            {
                new_price.Text = price.ToString();
            }
            product.update(Convert.ToInt32(id.Text), new_name.Text, Convert.ToSingle(new_price.Text),status);
            update_local(Convert.ToInt32(id.Text), new_name.Text, Convert.ToSingle(new_price.Text), status);
            message.Text = "updated";
            message.Visibility = Visibility.Visible;
            timer.Start();
        }

        private void get_old_tetail(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(id.Text);
            if (product.available(Id))
            {
                message1.Text = "";
                message1.Visibility = Visibility.Hidden;
                search_local(Id);
            }
            else
            {
                id.Text = "err";
    
                message1.Text = "Not Available";
                message1.Visibility = Visibility.Visible;
               
            }
        }
        private void search_local(int Id)
        {
            foreach (var item in Product_repository.productList)
            {
                if (item.Prodid == Id)
                {
                    //  Console.WriteLine("product name=" + item.Pname + "\nproduct price" + item.Price);
                    old_name.Text = pname = item.Pname;
                    old_price.Text = Convert.ToString(price = item.Price);
                    old_status.Text = item.Status;
                    break;
                }
            }
        }
        private void update_local(int id, string name, float price, string status)
        {
            foreach (var item in Product_repository.productList)
            {
                if (item.Prodid == id)
                {
                  
                    item.Pname=name;
                     item.Price=price;
                    item.Status=status;
                    break;
                }
            }
        }

        private void true_btn_Checked(object sender, RoutedEventArgs e)
        {
             status = "true";
        }

        private void false_btn_Checked(object sender, RoutedEventArgs e)
        {
            status = "false";
        }

     
        
    }
}
