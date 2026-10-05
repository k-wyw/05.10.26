using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class StudentDiscount : IDiscount
    {
        public decimal Apply(decimal price)
        {
            return price * 0.9m;
        }
    }
}
