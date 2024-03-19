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
    /// Interaction logic for view_emp.xaml
    /// </summary>
    public partial class view_emp : Page
    {
        employee_repository emp;
        public view_emp()
        {
            emp = new employee_repository();

            InitializeComponent();
            employee_tetail.ItemsSource = emp.employee_list;
        }
    }
}
