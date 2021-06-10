using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

           Console.WriteLine("*******************");
           //LogManager sayesinde yukarıdaki işlemleri yapmaya gerek kalmadı
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}
