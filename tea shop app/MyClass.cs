using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop_app
{
    public class MyClass : INotifyPropertyChanged
    {
        private bool _MyProp;

        public bool MyProp
        {
            get { return _MyProp; }
            set
            {
                if (_MyProp != value)
                {
                    _MyProp = value;
                    OnPropertyChanged("MyProp");

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
    }
}
