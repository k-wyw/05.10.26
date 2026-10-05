using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class ConsoleSender : IMessageSender
    {
        public void Send(string receiver, string message)
        {
            Console.WriteLine($"Уведомление для {receiver}: {message}");
        }
    }
}
