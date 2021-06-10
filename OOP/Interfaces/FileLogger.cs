using System;

namespace Interfaces
{
    public class FileLogger:ILogger
    {
         public void WriteLog()
        {
            //throw new NotImplementedExceptin();
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}