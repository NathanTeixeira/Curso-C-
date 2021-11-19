using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCursoCSharp.Entities {
    class Product {

        public String Name { get; set; }
        public double Price { get; private set; }
        //public List<Product> products { get; set; } = new List<Product>();

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag() {
            return Name + " R$ " + Price;
        }
    }
}
