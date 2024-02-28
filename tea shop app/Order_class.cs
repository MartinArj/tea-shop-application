using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
    class Order_class
    {
       // Order_repository or = new Order_repository();
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
          set { _quantity = value; }
}
        private float _subtotal;

        public float Subtotal
        {
            get { return _subtotal; }
            
           
        }
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
        public Order_class()
        { 
        }
        public Order_class(Product product, int quatity)
        { float unitp=unitPrice(product.Pname);
            this._id = product.Prodid;
            this._pname = product.Pname;
            this._quantity= quatity;
            this._unitprice = unitp;
            this._subtotal = unitp * quatity;
           
            

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
