using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace tea_shop_app
{
    class bill
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
        public bill()
        { 
        
        }

        public bill(Order_repository p, string billdate)
        {
            bill_rep temp = new bill_rep();
            float temp_am=0;
            foreach (var item in p.orderlist)
            {
                temp_am += item.Subtotal;
            }
            
            this._amount = (int)temp_am;
            this._billno = temp.lost_bill_no()+1;
            this.date = billdate;
        }
        public void AddBill()
        {
            bill_rep.bill_list.Add(this);
        }
       
     

    }
}
