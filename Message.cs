using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено!");
        }
       
    }
    class Email: Message
    { 
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }
    class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }
}
