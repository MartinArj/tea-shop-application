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

namespace tea_shop_app
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        Order_class order = new Order_class();
        Order_repository order_rep = new Order_repository();
        public OrderPage()
        {
            InitializeComponent();
            //ordertetail orderp = new ordertetail();
            //orderp.id = 1;
            //orderp.name = "tea";
            //orderp.price = 1;
            //orderp.quantity = 1;
            //orderp.subtotal = 1;
          //  productxaml.ItemsSource = order_rep.orderlist;
            Order_class order = new Order_class();
            Order_repository order_rep = new Order_repository();
            Product_repository p = new Product_repository();
        }

        float tot = 0;
        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(product_id.Text);
            int quatity = int.Parse(quantity_val.Text);
            string pname = Product_repository.prod_dic[id];
            Order_class temp=new Order_class(order.prodct_tetail(pname), quatity);
            order_rep.add_order(temp);
            product_id.Clear();
            quantity_val.Clear();
            tot+=temp.Subtotal;
            total_price.Text = tot.ToString();
            productxaml.ItemsSource = order_rep.orderlist;
        }
       
        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            string date = DateTime.Today.ToString("dd/mm/yyyy");
            bill bill = new bill(order_rep,date);
            bill_rep bill_rep = new bill_rep();
            bill.AddBill();
            bill_rep.loadbill(bill);
            order_rep.order_completed();
            order_rep.orderlist.Clear();
            tot = 0;
            total_price.Text = tot.ToString();
        }
    }
  
}
