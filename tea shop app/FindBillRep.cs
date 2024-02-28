using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
namespace tea_shop_app
{
   public class FindBillRep
   {
       get_bill get_bill = new get_bill();
       Product_repository temp = new Product_repository();
       public List<string> idlist = new List<string>();
       public ObservableCollection<string> datelist = new ObservableCollection<string>();
       public Dictionary<string, string> id_date = new Dictionary<string, string>();
       public Dictionary<int, get_bill> get_bill_tetail = new Dictionary<int, get_bill>();

        string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
      public  FindBillRep()
        {
           
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select billid,billdate from bills";
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idlist.Add(Convert.ToString(dr["billid"]));
                    id_date[Convert.ToString(dr["billid"])] = Convert.ToString(dr["billdate"]);
                    if (!datelist.Contains(dr["billdate"]))
                    { datelist.Add(Convert.ToString(dr["billdate"])); }
                }
            }
        
        }
       public void fetch_data(int id )
       {
           using (SqlConnection con = new SqlConnection(path))
           {
               con.Open();
               
               SqlCommand cmd2 = new SqlCommand();
               cmd2.Connection = con;
               cmd2.CommandText = "select billid,productid,quantity,subtotal from orders where billid=" + id + "";
               SqlDataReader dr2;
               dr2 = cmd2.ExecuteReader();
               get_bill.Order.Clear();
               int o_no = 0;
               while (dr2.Read())
               {
                   o_no++;
                   
               //  int bill_id=Convert.ToInt32( dr2["billid"]);
                 string name = Product_repository.prod_dic[Convert.ToInt32(dr2["productid"])];
                 int quantity=Convert.ToInt32(dr2["quantity"]);
                 double subtotal = Convert.ToDouble(dr2["subtotal"]);
                 get_bill.Order.Add(new get_order(o_no, name, quantity, subtotal));
               
               }
               dr2.Close();
         
          

               
               cmd2.CommandText = "select amount,billdate from bills where billid=" + id + "";
               SqlDataReader dr1;
               dr1 = cmd2.ExecuteReader();
               Double amount = 0;
               string date = "";
               if (dr1.Read())
               {
                  amount = Convert.ToDouble(dr1["amount"]);
                     
                    date=Convert.ToString(dr1["billdate"]);
                    
               }
              // get_bill getbill= 
               get_bill_tetail[id] = new get_bill(id, date, amount,get_bill.Order);
               dr1.Close();
           }
          
       }
      
    }
   public class get_order
   {

       private int _id;

       public int Id
       {
           get { return _id; }
           set { _id = value; }
       }
       private string _name;

       public string Name
       {
           get { return _name; }
           set { _name = value; }
       }
       private int _quantity;

       public int Quantity
       {
           get { return _quantity; }
           set { _quantity = value; }
       }
       private double _subtotal;

       public double Subtotal
       {
           get { return _subtotal; }
           set { _subtotal = value; }
       }
       public get_order()
       {

       }
       
       public get_order(int id ,string name,int qt,double sub)
       { this._id=id;
         this._name=name;
         this._quantity=qt;
         this._subtotal=sub;
       }
       public void add(get_bill temp)
       {
          temp.Order.Add(this);
       }
   }
   public class get_bill
   {

       public get_bill()
       { }

       private int _billid;
       private ObservableCollection<get_order> _order = new ObservableCollection<get_order>();

       public ObservableCollection<get_order> Order
       {
           get { return _order; }
           set { _order = value; }
       }
       public int Billid
       {
           get { return _billid; }
           set { _billid = value; }
       }
      
       
       private string _date;

       public string Date
       {
           get { return _date; }
           set { _date = value; }
       }
       private double _amount;

       public double Amount
       {
           get { return _amount; }
           set { _amount = value; }
       }
     

    
       public get_bill(int billid,string date,double amont,ObservableCollection<get_order> list)
       { 
           this._billid=billid;
           this._date=date;
           this._amount = amont;
           this._order = list;


          
       }
     
     

   
   }
}
