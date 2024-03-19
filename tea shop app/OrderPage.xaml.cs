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
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
       
        Order_class order = new Order_class();
        bill_rep bill_rep = new bill_rep();
        private DispatcherTimer timer;
        bill bill ;
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
           
             timer = new DispatcherTimer();
             timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick+=timer_Tick;
            bill =new bill();
            this.DataContext = bill.orderlist;
            total_price.Text = Total.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            product_id.Clear();
            copy_message.Visibility = Visibility.Hidden;
            not_avl.Visibility = Visibility.Hidden;
            Add.Background = Brushes.WhiteSmoke;
            timer.Stop();
        }
        Product_repository pr = new Product_repository();
     
      private  int ono = 0;
      private double _Total = 0;

      public double Total
      {
          get { return _Total; }
          set { _Total = value; }
      }
        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(product_id.Text);
            int quatity = int.Parse(quantity_val.Text);
            if (pr.available(id))
            {
                
                string pname = Product_repository.prod_dic[id];
                Order_class temp = new Order_class(order.prodct_tetail(pname), quatity, ++ono);
                if (!bill.verify_l.Contains(temp.Id))
                {
                   
                    bill.add_order(temp);
                    bill.verify_l.Add(temp.Id);
                    
                    product_id.Clear();
                    quantity_val.Clear();
                    _Total += temp.Subtotal;
                    
                }
                else
                {
                    copy_message.Visibility = Visibility.Visible;
                    timer.Start();
                }

                total_price.Text = _Total.ToString();
                this.DataContext = bill;
            }
            else
            {
                not_avl.Visibility = Visibility.Visible;
                Add.Background = Brushes.Red;
                timer.Start();
            }
           
        }
       
        private void Save_Click_1(object sender, RoutedEventArgs e)
        {
            bill newbill = new bill();


          
            newbill.AddBill(bill);
            newbill.load_bill(bill);
            bill_rep.loadbill(bill);
            bill_rep.order_completed(bill.orderlist);
            bill.orderlist.Clear();
            bill.verify_l.Clear();
            
            _Total = 0;
            total_price.Text = _Total.ToString();
        }

        private void remove_Click_1(object sender, RoutedEventArgs e)
        {
            remove_panal.Visibility = Visibility.Visible;
        }

        private void remove_at_Click_1(object sender, RoutedEventArgs e)
        {

            if (bill.verify_l.Contains((int.Parse(remove_textbox.Text))))
            {
                float ramove_amount = bill.remove_order(int.Parse(remove_textbox.Text));
                _Total = _Total - (int)ramove_amount;
                total_price.Text = _Total.ToString();
            }
            else 
            {
                remove_textbox.Foreground = Brushes.Red;
                
            }
            remove_panal.Visibility = Visibility.Hidden;

        }

        private void remove_lost_Click_1(object sender, RoutedEventArgs e)
        {
            float ramove_amount = bill.remove_order(ono);
            _Total = _Total - (int)ramove_amount;
            total_price.Text = _Total.ToString();
            remove_panal.Visibility = Visibility.Hidden;
        }

        private void update_Click_1(object sender, RoutedEventArgs e)
        {
            update_panel.Visibility = Visibility.Visible;
        }

        private void update_qt_Click_1(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(update_id.Text);
            int quantity = int.Parse(update_quantity.Text);
            if (bill.verify_l.Contains((id)))
            {
                foreach (var item in bill.orderlist)
                {
                    float old_sub=0;
                    if (id == item.Id)
                    {
                        item.Quantity = quantity;
                        old_sub = item.Subtotal;
                        item.Subtotal = item.Quantity * item.Unitprice;
                        _Total = _Total - old_sub + item.Subtotal;
                        total_price.Text = _Total.ToString();
                        this.DataContext = bill_rep;
                        update_panel.Visibility = Visibility.Visible;
                        break;
                    }
                }
            }
        }
       
        private void pass_Click_1(object sender, RoutedEventArgs e)
        {
            bill newbill = new bill();
          
            pass_order pass_order_tetail = new pass_order();
           // order_rep.add(Total);
            //pass_order_tetail.pass_bill_add(bill.orderlist,Total);
            if (bill.orderlist.Count!=0)
            {
                pass_order_tetail.add_temp(bill);
                total_price.Text = "0";
                bill = newbill;
            }
            this.DataContext = bill;
            Total = 0;
        }
        private int current_bill = 0;
        private void passed_bill_Click_1(object sender, RoutedEventArgs e)
        {
            if (passed_bill.IsChecked==true)
            {
                pass_pannel.Visibility = Visibility.Visible;
            }
            else
            {
                pass_pannel.Visibility = Visibility.Hidden;
            }
        }

        private void Passed_Bill_Next_Click_1(object sender, RoutedEventArgs e)
        {
            if (current_bill < pass_order.Pass_list.Count - 1)
            {
                current_bill++;
                bill = pass_order.Pass_list[current_bill];
                Total = bill.current_Amount();
                this.DataContext = bill;
                total_price.Text = Total.ToString();
            }

        }

        private void Passed_Bill_privious_Click_1(object sender, RoutedEventArgs e)
        {
            if (current_bill > 0)
            {
                current_bill--;
                bill = pass_order.Pass_list[current_bill];
                Total = bill.current_Amount();
                this.DataContext =bill;
                total_price.Text = Total.ToString();
            }
        }

        private void Passed_Bill_lost_Click_1(object sender, RoutedEventArgs e)
        {
            current_bill = pass_order.Pass_list.Count - 1;
            bill= pass_order.Pass_list[current_bill];
            Total = bill.current_Amount();
            this.DataContext = bill;
            total_price.Text = Total.ToString();
        }

      
    }
  
}
