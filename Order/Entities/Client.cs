using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Entities {
    class Client {

        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString() {
            return "Nome: " + Name + " (" + birthDate + ") " + " Email: " + Email;
        }
    }
}
