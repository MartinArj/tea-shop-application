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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string,string> log_dic_laber = new Dictionary<string, string>();
        Dictionary<string, string> log_dic_manager = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
            log_dic_laber["martinaraj"] = "9003459797";
            log_dic_manager["qwer"] = "12345";
            id.Text = "martinaraj";
            password.Text = "9003459797";
        }
        private bool jecklogin_laber(string id,string pass)
        {
            bool correct = false;
            if (log_dic_laber.ContainsKey(id))
            {
                if (log_dic_laber.ContainsValue(pass))
                {
                    correct = true;

                }
             

            }
         
           
            return correct;
        }
        private bool jecklogin_manager(string id, string pass)
        {
            bool correct = false;
            if (log_dic_manager.ContainsKey(id))
            {
                if (log_dic_manager.ContainsValue(pass))
                {
                    correct = true;

                }
               

            }

           
            return correct;
           
        
        }

        private void login_btn(object sender, RoutedEventArgs e)
        {
            string lid = id.Text;
            string lpass = password.Text;
           
            if (jecklogin_laber(lid,lpass) ) //it is return password correct or not
            {
               // MessageBox.Show("welcome laber","INFORM", MessageBoxButton.OK, MessageBoxImage.Information);
                LaberWindow laber = new LaberWindow();
                laber.Show();
                this.Close();
            }
            if (jecklogin_manager(lid, lpass)) //it is return password correct or not
            {

                ManagerWindow managerwindow = new ManagerWindow();


                managerwindow.Show();
                    this.Close();
            }
        }  

       

      
       
    }
}
