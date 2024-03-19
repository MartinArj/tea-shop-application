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
    /// Interaction logic for view.xaml
    /// </summary>
    public partial class view : Page
    {
        Product_repository prod;

        public view()
        {
            InitializeComponent();
            prod = new Product_repository();
            view_data();

        }
        private void view_data()
        {
            product_tetail.ItemsSource = Product_repository.productList;
            
        
        }

    }
}
