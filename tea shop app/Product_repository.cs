﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace tea_shop_app
{
  public  class Product_repository
    {
        string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
       public static Dictionary<int, string> prod_dic = new Dictionary<int, string>();
       public static List<Product> productList = new List<Product>();
       public Product_repository()
       {
           ////productList.Add(new product("tea", 10));
           ////productList.Add(new product("cofee", 15));
           ////productList.Add(new product("milk", 10));
           ////productList.Add(new product("snacks", 5));
           ////productList.Add(new product("bicuits", 10));
           ////productList.Add(new product("vada", 10));
           if (productList.Count == 0)
           {
               using (SqlConnection con = new SqlConnection(path))
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand();
                   cmd.Connection = con;
                   cmd.CommandText = "SELECT * FROM PRODUCT";
                   SqlDataReader dr;
                   dr = cmd.ExecuteReader();
                   while (dr.Read())
                   {
                       string s = Convert.ToString(dr["name"]);
                       float f = Convert.ToSingle(dr["price"]);
                       int id = Convert.ToInt32(dr["id"]);
                       string status = Convert.ToString(dr["availablity"]);
                       if (status.ToUpper() == "TRUE")
                       {
                           productList.Add(new Product(s, f, id, status));
                           prod_dic[id] = s;
                       }
                       
                   }

               }
           }
       }
       public int lostproductid()
       {
           using (SqlConnection con = new SqlConnection(path))
           {
               con.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = "SELECT * FROM PRODUCT";
               SqlDataReader dr;
               dr = cmd.ExecuteReader();
               int id=0;
               while (dr.Read())
               {
                  
                   id = Convert.ToInt32(dr["id"]);
                  
                   
               }
               return id;

           }
       
       }
      
     public  void addproduct(string name,float price,string status="true")
       {
           int id =this.lostproductid();
           using (SqlConnection con = new SqlConnection(path))
           {
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               con.Open();
               cmd.CommandText = "INSERT INTO product(name,price,availablity) values('"+name+"',"+price+",'"+status+"')";
          
               cmd.ExecuteNonQuery();
               Product_repository.productList.Add(new Product(name, price,++id,status));
               prod_dic[id] = name;
              // Console.WriteLine("*****insert sucsess*****");
              // MessageBox.Show("message", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
       
       
           }
       }
       public bool available(int id)
     {
         bool a = false;
           foreach (var item in productList)
           {
               if (item.Prodid == id)
               {
                   a = true;
               }
           }
           return a;
       }
       public void update(int id,string pname,float price,string status)
       {
           if (available(id))
              {
               
                       using (SqlConnection con = new SqlConnection(path))
                       {
                           SqlCommand cmd = new SqlCommand();
                           cmd.Connection = con;
                           con.Open();
                           cmd.CommandText = "update product set name='"+pname+"',price="+price+",availablity='"+status+"' where id="+id+"";
                       
                           cmd.ExecuteNonQuery();
                      
                       }
                       foreach (var item in productList)
                       {
                           if (item.Prodid == id)
                           {
                              
                              item.Pname=pname;
                              item.Price=price;
                           }
                       }
             }

        }
       public void delete(int id)
       {
           if (available(id))
           {
               using (SqlConnection con = new SqlConnection(path))
               {
                   SqlCommand cmd = new SqlCommand();
                   cmd.Connection = con;
                   con.Open();
                   cmd.CommandText = "delete from product where id="+id+"";
                 
                   cmd.ExecuteNonQuery();

               }
               foreach (var item in productList)
               {
                   if (item.Prodid == id)
                   {

                       Console.WriteLine(item.Pname);
                       Console.WriteLine(item.Price);
                       productList.Remove(item);
                       prod_dic.Remove(id);
                   }
                   
               }
           
           }
       }
  
    }
}
