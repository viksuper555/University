using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWFormsApp
{
    public delegate void ProductChangedDelegate();

    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnChangeProduct?.Invoke(); }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; OnChangeProduct?.Invoke(); }
        }

        private string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; OnChangeProduct?.Invoke(); }
        }
        public override string ToString()
        {
            return Name;
        }

        public event ProductChangedDelegate OnChangeProduct;
    }
}
