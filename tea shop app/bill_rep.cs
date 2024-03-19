using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
namespace tea_shop_app
{
    class bill_rep
    {
        string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
        public static List<bill> bill_list = new List<bill>();
        public int lost_bill_no()
        {
            int lost_id = 0;
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select top 1 billid from bills order by billid desc;";
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lost_id = Convert.ToInt32(dr["billid"]);
                }
            }
            return lost_id;

        }
        public void loadbill(bill bill)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO  bills values(" + bill.Amount + ",'" + bill.date + "')";
                cmd.ExecuteNonQuery();
            }
        }
       
        public void order_completed(ObservableCollection<Order_class> orderlist)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT top 1 billid FROM bills order by billid desc;";
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int billid = 0;
                while (dr.Read())
                {
                    billid = Convert.ToInt32(dr["billid"]);
                }
                dr.Close();
                foreach (var item in orderlist)
                {
                    cmd.CommandText = "INSERT INTO orders values(" + billid + "," + item.Id + "," + item.Quantity + "," + item.Subtotal + ")";
                    cmd.ExecuteNonQuery();
                }



            }

        }
       
       
       
    }
}
