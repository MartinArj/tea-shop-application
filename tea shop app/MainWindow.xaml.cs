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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        employee_repository employee;

        DispatcherTimer timer;
        Dictionary<string,string> log_dic_laber = new Dictionary<string, string>();
        Dictionary<string, string> log_dic_manager = new Dictionary<string, string>();
        public MainWindow()
        {
            employee = new employee_repository();
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            message.Text = null;
            timer.Stop();
        }
        private bool jecklogin_laber(string id,string pass)
        {
            bool correct = false;
            if (employee.laber.ContainsKey(id))
            {
                if ((employee.laber[id]==pass))
                {
                    correct = true;

                }
                else
                {
                    message.Text = "incorect password";
                    timer.Start();
                }
             

            }
         
           
            return correct;
        }
        private bool jecklogin_manager(string id, string pass)
        {
            bool correct = false;
            if (employee.manager.ContainsKey(id))
            {
                if (employee.manager[id] == pass)
                {
                    correct = true;

                }
                else
                {
                    message.Text = "incorect password";
                    timer.Start();
                }
               

            }

           
            return correct;
           
        
        }

        private void login_btn(object sender, RoutedEventArgs e)
        {
            string log_id = id.Text;
            string log_pass = password.Text;
           
            if (jecklogin_laber(log_id,log_pass) ) //it is return password correct or not
            {
               // MessageBox.Show("welcome laber","INFORM", MessageBoxButton.OK, MessageBoxImage.Information);
                LaberWindow laber = new LaberWindow();
                laber.Show();
                this.Close();
            }
            else if (jecklogin_manager(log_id, log_pass)) //it is return password correct or not
            {

                ManagerWindow managerwindow = new ManagerWindow();
                managerwindow.Show();
                this.Close();
            }
            else
            {
                message.Text = "incorrect id and pass word!";
                timer.Start();
            
            }
        }  

       

      
       
    }
}
