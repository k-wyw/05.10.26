using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class OrderService
    {
        private readonly OrderCalculator calculator;
        private readonly IMessageSender sender;

        public OrderService(OrderCalculator calculator, IMessageSender sender)
        {
            this.calculator = calculator;
            this.sender = sender;
        }

        public void ProcessOrder(Order order)
        {
            decimal finalPrice = calculator.Calculate(order);

            Console.WriteLine($"Заказ клиента {order.CustomerName} сохранён");

            sender.Send(order.Email, $"Заказ оформлен. Итоговая цена: {finalPrice}");

            Console.WriteLine($"Клиент: {order.CustomerName}");
            Console.WriteLine($"Исходная цена: {order.Price}");
            Console.WriteLine($"Итоговая цена: {finalPrice}");
        }
    }
}
