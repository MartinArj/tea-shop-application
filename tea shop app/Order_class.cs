using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
    public class Order_class : INotifyPropertyChanged
    {

        public Order_class()
        {
        }
        public Order_class(Product product, int quatity, int ono)
        {
            float unitp = unitPrice(product.Pname);
            this._id = product.Prodid;
            this._pname = product.Pname;
            this._quantity = quatity;
            this._unitprice = product.Price;
            this._subtotal = unitp * quatity;

            this.Ono = ono;



        }
       // Order_repository or = new Order_repository();
        private int _ono;

        public int Ono
        {
            get { return _ono; }
            set { _ono = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }

        }
        private string _pname;

        public string Pname
        {
            get { return _pname; }

        }
        private float _unitprice;

        public float Unitprice
        {
            get { return _unitprice; }
        }

     

        private int _quantity;
     
        public int Quantity
        {
          get { return _quantity; }
          set
          {
              if (_quantity != value)
              {
                  _quantity = value;
                  OnPropertyChanged("Quantity");
              }
          }
}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private float _subtotal;

        public float Subtotal
        {
            get { return _subtotal; }
            set
            {
                if (_subtotal != value)
                {
                    _subtotal = value;
                    OnPropertyChanged("Subtotal");
                }
            }
            
           
        }
        //public bool MyProp
        //{
        //    get { return _MyProp; }
        //    set
        //    {
        //        if (_MyProp != value)
        //        {
        //            _MyProp = value;
        //            OnPropertyChanged("MyProp");

        //        }

        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
 
        public float unitPrice(string pname)
        {
            float Up = 0;
            foreach (var item in Product_repository.productList)
            {
               
                if (pname == item.Pname)
                {
                    Up= item.Price;
                    break;
                }
                
            }
            return Up;
        }
      
        public Product prodct_tetail(string prod_name)
        {
            Product t=new Product();
            foreach (Product item in Product_repository.productList)
            {

                if (prod_name == item.Pname)
                {
                    t = item;
                    break;
                }

            }
            return t;

        }
    }
}
