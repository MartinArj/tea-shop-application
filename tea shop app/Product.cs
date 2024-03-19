using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
  public  class Product
    {
         private string _pname;

        public string Pname
        {
            get { return _pname; }
            set { _pname = value; }
        }
        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _prodid;

        public int Prodid
        {
            get { return _prodid; }
           
        }
        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        
        public Product()
        { }

        public Product(string name, float price,int pid,string status)
        {
            this._pname = name;
            this._price = price;
            this._prodid = pid;
            this._status = status;
        }
    }
}
