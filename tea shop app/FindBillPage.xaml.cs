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
    /// Interaction logic for FindBillPage.xaml
    /// </summary>
    public partial class FindBillPage : Page
    {
        private List<string> itemList1 = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4" ,"martin","raja"};
        MyClass v = new MyClass();
        public FindBillPage()
        {
          
            InitializeComponent();
   
         
            UpdateListBoxItems(itemList1);
          
           
           // v.isvisible = string.IsNullOrEmpty(searchText);
            // comboBoxItems.ItemsSource = itemList;
            v.MyProp = false;
            findbillgrid.DataContext = v;
        }
        // Event handler for text changes in the search box
        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
            string searchText = textBoxSearch.Text.ToLower();
           
            // Filter items based on search text
            List<string> filteredItems = new List<string>();
            foreach (string item in itemList1)
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
            if (items.Count != 0) { v.MyProp = true; }
            listBoxItems.ItemsSource = null;
            listBoxItems.ItemsSource = items;
          
        }

        //private void listBoxItems_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        //{
        //    if (listBoxItems.SelectedItem != null)
        //    {
        //        textBoxSearch.Text = listBoxItems.SelectedItem.ToString();
        //    }
        //}


        //________________________________________________________________________________________________________________________________
        // demo
          // Sample list of items
      
    }
    public class MyClass
    {
        public bool MyProp { get; set; }  
    
    }
}
    