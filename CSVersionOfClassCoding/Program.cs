using System;

namespace CSVersionOfClassCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToString("f"));
            ILogger aLogger = new AsteriskLogger();
            aLogger.Error("This is an Error!");
            aLogger.Log("This is a Log.");

            ILogger sLogger = new SpacedLogger();
            sLogger.Error("ErrorError");
            sLogger.Log("LogLogLog");

        }
    }
}