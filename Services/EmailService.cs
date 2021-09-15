using System;

namespace HomeWork.Services
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine("sent by email:");
            Console.WriteLine(message);
        }
    }
}