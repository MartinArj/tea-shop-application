using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
  public  class employee
    {
        private int _empid;

        public int Empid
        {
            get { return _empid; }
            set { _empid = value; }
        }
        private string _userid;

        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        private string _pass_word;

        public string Pass_word
        {
            get { return _pass_word; }
            set { _pass_word = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _dob;

        public string Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _aadhar;

        public string Aadhar
        {
            get { return _aadhar; }
            set { _aadhar = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public employee() { }
        public employee(int id,string name,string dob,string phone,string aadhar,string userid,string pass_word,string type,string email)
        { 
        this._empid=id;
        this._name=name;
        this._dob=dob;
        this._phone=phone;
        this._aadhar=aadhar;
        this._userid=userid;
        this._pass_word=pass_word;
        this.Type=type;
        this._email = email;
        }
        }
}  