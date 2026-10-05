using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("Иван Иванов", "ivan@example.com", 10000, CustomerType.Student);

            IDiscount discount;
            if (order.CustomerType == CustomerType.Student)
                discount = new StudentDiscount();
            else if (order.CustomerType == CustomerType.Vip)
                discount = new VipDiscount();
            else
                discount = new NoDiscount();

            OrderCalculator calculator = new OrderCalculator(discount);
            IMessageSender sender = new EmailSender();

            OrderService service = new OrderService(calculator, sender);

            service.ProcessOrder(order);
        }
    }
}
