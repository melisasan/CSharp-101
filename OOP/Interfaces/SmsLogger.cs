using System;

namespace Interfaces
{
    public class SmsLogger:ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedExceptin();
            Console.WriteLine("Sms olarak yazar.");
        }
    }
}