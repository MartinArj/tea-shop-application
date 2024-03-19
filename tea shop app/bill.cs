using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
namespace tea_shop_app
{
  public  class bill
    {
         private int _billno ;
        

       
        public int Billno
        {
            get { return _billno; }
            set { _billno = value; }
        }
        public string date;


        private int _amount = 0;

        public int Amount
        {
            get { return _amount; }

        }
        private ObservableCollection<Order_class> _orderlist;

        public ObservableCollection<Order_class> orderlist
        {
            get { return _orderlist; }
            set { _orderlist = value; }
        }
        public bill()
        { 
           _orderlist = new ObservableCollection<Order_class>();
        }
        string billdate = DateTime.Now.ToString("dd/mm/yyyy");
        public void load_bill(bill temp)
        {
            bill_rep temp1 = new bill_rep();
            float temp_am=0;
            foreach (var item in orderlist)
            {
                temp_am += item.Subtotal;
            }
            
            this._amount = (int)temp_am;
            this._billno = temp1.lost_bill_no()+1;
            this.date = billdate;
        }
       
        public List<int> verify_l = new List<int>();
      
        public void add_order(Order_class temp)
        {
            if (!verify_l.Contains(temp.Id))
            {
                orderlist.Add(temp);
            }
        }
       
        
        public float remove_order(int id)
        {
            float remove_amount = 0;
            foreach (var item in orderlist)
            {
                if (id == item.Id)
                {
                    remove_amount = item.Subtotal;
                    orderlist.Remove(item);
                    break;
                }

            }
            return remove_amount;

        }
        public void AddBill(bill temp)
        {
            float temp_am = 0;
            foreach (var item in orderlist)
            {
                temp_am += item.Subtotal;
            }

            this._amount = (int)temp_am;
            this.orderlist = temp.orderlist;
            this.date = billdate;
            bill_rep.bill_list.Add(this);
        }
        public double current_Amount()
        {
            double temp_amount = 0;
            foreach (var item in orderlist)
            {
                temp_amount += item.Subtotal;
            }
            return temp_amount;
        
        }
       
     

    }
}
