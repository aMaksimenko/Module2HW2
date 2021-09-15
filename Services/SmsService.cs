using System;

namespace HomeWork.Services
{
    public class SmsService
    {
        public void Send(string message)
        {
            Console.WriteLine("sent by SMS:");
            Console.WriteLine(message);
        }
    }
}