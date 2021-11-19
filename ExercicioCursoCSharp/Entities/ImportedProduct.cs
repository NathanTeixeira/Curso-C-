using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCursoCSharp.Entities {
    class ImportedProduct : Product {

        public double customsFree { get; private set; }

        public ImportedProduct(string name, double price, double customsFree) : base (name, price) {
            this.customsFree = customsFree;
        }

        public double TotalPrice() {
            return Price + customsFree;
        }

        public override string PriceTag() {
            return Name+ " R$ " + TotalPrice() + " (CUSTOMS FREE: R$ " + customsFree + ")";
        }

    }
}
