using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class OrderCalculator
    {
        private readonly IDiscount discount;

        public OrderCalculator(IDiscount discount)
        {
            this.discount = discount;
        }

        public decimal Calculate(Order order)
        {
            return discount.Apply(order.Price);
        }
    }
}
