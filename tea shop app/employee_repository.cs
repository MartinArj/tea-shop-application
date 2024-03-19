using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
namespace tea_shop_app
{
  public  class employee_repository
    {
        string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
    public Dictionary<string, string> laber = new Dictionary<string, string>();
      public  Dictionary<string, string> manager = new Dictionary<string, string>();
       public ObservableCollection<employee> employee_list = new ObservableCollection<employee>();
        public employee_repository()
        {
            if (employee_list.Count() == 0)
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select * from employee_detail";
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int id = int.Parse(dr["id"].ToString());
                        string name = dr["name"].ToString();
                        string dob = dr["dob"].ToString();
                        string phone = dr["phone"].ToString();
                        string aadhar = dr["aadhar"].ToString();
                        string userid = dr["userid"].ToString();
                        string pass_word = dr["pass_word"].ToString();
                        string status = dr["status"].ToString().ToUpper();
                        string email = dr["email_id"].ToString();
                        if (status == "MNG")
                        {
                            manager[userid] = pass_word;

                        }
                        if (status == "EMP")
                        {
                            laber[userid] = pass_word;

                        }
                        employee employee = new employee(id, name, dob, phone, aadhar, userid, pass_word, status,email);
                        employee_list.Add(employee);
                    }
                }
            }

        }
        public void addemp(string name,string dob,string phone,string aadhar,string userid,string pass_word,string type,string email)
        {
            int id = lost_emp_id() + 1;
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into employee_detail values ('" + name + "','" + dob + "','" + phone + "','" + aadhar + "','" + userid + "','" + pass_word + "','" + type + "','"+email+"')";
                
                cmd.ExecuteNonQuery();
                employee employee = new employee(id, name, dob, phone, aadhar, userid, pass_word,type,email);
                employee_list.Add(employee);
            }
        
        }
        public void deleteemp(int id)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "delete from employee_detail where id="+id+"";
                foreach (var item in employee_list)
                {
                    if (item.Empid == id)
                    {
                        employee_list.Remove(item);
                        break;
                    }
                }
                cmd.ExecuteNonQuery();

            }

        }
        public void updateemp(int id, string name, string dob, string phone, string aadhar, string userid, string pass_word, string type)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "update emloyee_detail set name='"+name+"',dob='"+dob+"',phone='"+phone+"',aadhar='"+aadhar+"',useid='"+userid+"',pass_word='"+pass_word+"',type='"+type+"'";
                foreach (var item in employee_list)
                {
                    if (item.Empid == id)
                    {
                        item.Name = name;
                        item.Dob=dob;
                        item.Phone=phone;
                        item.Aadhar=aadhar;
                        item.Userid=userid;
                        item.Pass_word=pass_word;
                        item.Type=type;
                        break;
                    }
                }
                cmd.ExecuteNonQuery();

            }

        }
        public int lost_emp_id()
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select top 1 id from employee_detail order by id desc";
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = int.Parse(dr["id"].ToString());
                }
            }
            return id;
        }
        public employee get_detail(int id)
        {
            employee temp=new employee();
            foreach (var item in employee_list)
            {
                
                if (id == item.Empid)
                {
                    temp = item;
                    break;

                }
              
                
            }
            return  temp;
        
        }
  
    
    }
    }

