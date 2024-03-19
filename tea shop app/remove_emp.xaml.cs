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
    /// Interaction logic for remove_emp.xaml
    /// </summary>
    public partial class remove_emp : Page
    {
        DispatcherTimer timer;
        employee_repository emp;
        public remove_emp()
        {
            InitializeComponent();
            emp = new employee_repository();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            message.Text = "";
            tetail.Text = "";
            id.Text = null;
            timer.Stop();

        }
        bool avl;
        private void get_Click_1(object sender, RoutedEventArgs e)
        {
            int Id = int.Parse(id.Text);
            employee temp = emp.get_detail(Id);
            if (temp != null)
            {
                tetail.Text = "Name:" + temp.Name + "\nDOB:" + temp.Dob + "\nPhone:" + temp.Phone + "";
                avl = true;
            }

        }

        private void remove_Click_1(object sender, RoutedEventArgs e)
        {
            if (avl)
            {
                emp.deleteemp(int.Parse(id.Text));
                message.Text = "deleted";
                avl = false;
                timer.Start();
            }
        }
    }
}
