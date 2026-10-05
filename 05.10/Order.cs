using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public decimal Price { get; set; }
        public CustomerType CustomerType { get; set; }

        public Order(string customerName, string email, decimal price, CustomerType customerType)
        {
            CustomerName = customerName;
            Email = email;
            Price = price;
            CustomerType = customerType;
        }
    }
}
