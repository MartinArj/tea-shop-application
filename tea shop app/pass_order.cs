using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
    class pass_order
    {
      public  bill temp_bill;
        bill_rep bill_rep = new bill_rep();
      public static ObservableCollection<bill> Pass_list = new ObservableCollection<bill>();

    
       public void add_temp(bill temp)
       {
       this.temp_bill=temp;
       Pass_list.Add(temp_bill);
       }
      
    }
}
