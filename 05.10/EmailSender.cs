using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._10
{
    public class EmailSender : IMessageSender
    {
        public void Send(string receiver, string message)
        {
            Console.WriteLine($"Email для {receiver}: {message}");
        }
    }
}
