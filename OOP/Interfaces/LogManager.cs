using System;

namespace Interfaces
{
    //Hangi log sınıfının yaratılacağını belirleyen bir log manager
    //Sadece bu class implemente edilecek
    public class LogManager:ILogger
    {
        //Logger sınıfının instance'ını yaratır
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        //Iloggerdan türeyen nesnenin writelog metodu çağırılır
        public void WriteLog()
        {
            _logger.WriteLog();
        }

    }
}