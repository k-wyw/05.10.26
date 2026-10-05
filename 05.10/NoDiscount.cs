using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class NoDiscount : IDiscount
    {
        public decimal Apply(decimal price)
        {
            return price;
        }
    }
}
