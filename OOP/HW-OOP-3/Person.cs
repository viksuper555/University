using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWFormsApp
{
    public delegate void PersonChangeDelegate();
    public delegate void PersonNameChangeDelegate();
    public class Person
    {
        private List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        private void onProductChange()
        {
            OnChangePerson?.Invoke();
        }

        public void Add(Product product)
        {
            products.Add(product);

            product.OnChangeProduct += onProductChange;

            OnChangePerson?.Invoke();
        }

        public void Remove(Product product)
        {
            products.Remove(product);

            OnChangePerson?.Invoke();
        }

        public Product[] Find(string name)
        {
            var result = new List<Product>();

            foreach (var product in products)
                if (product.Name.StartsWith(name))
                    result.Add(product);

            return result.ToArray();
        }
        
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnChangePerson?.Invoke(); }
        }

        public string Num;

        public override string ToString()
        {
            return Name;
        }

        public event PersonNameChangeDelegate OnPersonNameChange;

        public PersonChangeDelegate OnChangePerson;

    }
}
