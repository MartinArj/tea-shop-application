using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using System.Collections.ObjectModel;

namespace tea_shop_app
{
    /// <summary>
    /// Interaction logic for FindBillPage.xaml
    /// </summary>
    public partial class FindBillPage : Page
    {

        FindBillRep obj1 = new FindBillRep();
      
        MyClass v = new MyClass();
        MyClass v1 = new MyClass();
        public FindBillPage()
        {
           
            InitializeComponent();
   
         
            
          
           
           // v.isvisible = string.IsNullOrEmpty(searchText);
            // comboBoxItems.ItemsSource = itemList;
            v.MyProp = false;
            v1.MyProp = false;
            idviwe.DataContext = v;
            dateviwe.DataContext = v1;
        }
        // Event handler for text changes in the search box
        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
            string searchText = textBoxSearch.Text.ToLower();
           
            // Filter items based on search text
            List<string> filteredItems = new List<string>();
            foreach (string item in obj1.idlist)
            {
                if (item.ToLower().Contains(searchText))
                {
                    filteredItems.Add(item);
                }
            }

            // Update ListBox with filtered items
            UpdateListBoxItems(filteredItems);
            
        }

        // Method to update ListBox items
        private void UpdateListBoxItems(List<string> items)
        {
            if (items.Count != 0)
            {
                v.MyProp = true;

            }
            else
            {
                v.MyProp = false;
            }
           
            listBoxItems.ItemsSource = null;
            listBoxItems.ItemsSource = items;
          
        }
      
        private void listBoxItems_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
               
                textBoxSearch.Text = listBoxItems.SelectedItem.ToString();
                textBoxSearch1.Text = obj1.id_date[textBoxSearch.Text];
            }
            v1.MyProp = false;
            v.MyProp = false;
          
        }

        private void textBoxSearch1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string searchText = textBoxSearch1.Text.ToLower();

            // Filter items based on search text
            List<string> filteredItems = new List<string>();
            foreach (string item in obj1.datelist)
            {
                if (item.ToLower().Contains(searchText))
                {
                    filteredItems.Add(item);
                }
            }

            // Update ListBox with filtered items
            UpdateListBoxItems_1(filteredItems);
        }
        private void UpdateListBoxItems_1(List<string> items)
        {
            if (items.Count != 0)
            {
                v1.MyProp = true;

            }
            else
            {
                v1.MyProp = false;
            }

            listBoxItems1.ItemsSource = null;
            listBoxItems1.ItemsSource = items;

        }
        private void listBoxItems1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxItems1.SelectedItem != null)
            {
                textBoxSearch1.Text = listBoxItems1.SelectedItem.ToString();
            }
            v1.MyProp = false;

        }

        private void find_btn_Click_1(object sender, RoutedEventArgs e)
        {
           
           
            obj1.fetch_data(Convert.ToInt32(textBoxSearch.Text));
          get_bill bill= obj1.get_bill_tetail[Convert.ToInt32(textBoxSearch.Text)];
          this.DataContext = bill;
          //bill_data.ItemsSource = bill.orders.order;
          //total_amount.DataContext = bill.amount;
          //bill_id_date_panel.DataContext = bill;
        }



     

      


        //________________________________________________________________________________________________________________________________
        // demo
          // Sample list of items
      
    }

   
    }

    