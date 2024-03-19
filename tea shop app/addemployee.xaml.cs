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
    /// Interaction logic for addemployee.xaml
    /// </summary>
    public partial class addemployee : Page
    {
        DispatcherTimer timer;
        public addemployee()
        {
            InitializeComponent();
            temp = new employee_repository();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            message.Text = "";
            message.Visibility = Visibility.Hidden;
            timer.Stop();
        }
        string ratio_btn_result;
        
        employee_repository temp;
        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            string Name = name.Text;
            string Dob = dob.Text;
            string Phone = phone.Text;
            string Aadhar = aadhar.Text;
            string Userid = userid.Text;
            string Password = password.Text;
            string Designation = ratio_btn_result;
            string Email = emailid.Text;
            try
            {
                temp.addemp(Name, Dob, Phone, Aadhar, Userid, Password, Designation, Email);
            }
            catch (Exception)
            {
                message.Text = "invalied data entered.";
                timer.Start();
                throw;
            }
            finally
            {
                name.Clear();
                dob.Clear();
                phone.Clear();
                aadhar.Clear();
                userid.Clear();
                password.Clear();
                ratio_btn_result = "";
                emailid.Clear();
                message.Text = "**** insert success *****";
                
            }
      
         
        }

        private void nanager_check_btn_Checked_1(object sender, RoutedEventArgs e)
        {

            ratio_btn_result = "mng";
        }

        private void laber_check_btn_Checked_1(object sender, RoutedEventArgs e)
        {
            ratio_btn_result = "emp";
        }
    }
}
