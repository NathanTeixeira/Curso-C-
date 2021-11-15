using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Entities {
    class OrderItem {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem() {
        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double subTotal() {
            double subtotal = Price * Quantity;
            return subtotal;
        }

        public override string ToString() {
            return product.Name + " R$" + Price + " Quantidade: " + Quantity + " SubTotal: R$" + subTotal();
        }
    }
}
