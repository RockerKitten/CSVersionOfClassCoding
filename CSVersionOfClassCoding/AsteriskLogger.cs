using System;
using CSVersionOfClassCoding;
using Microsoft.VisualBasic;

namespace CSVersionOfClassCoding
{
    public class AsteriskLogger : ILogger
    {
        public void Log(string word)
        {
            Console.WriteLine("***"+word+"***");
        }
        
        public void Error(string word)
        {
            string repeats = new String('*', word.Length);
            Console.WriteLine("*************"+repeats);
            Console.WriteLine("***Error: "+word+"***");
            Console.WriteLine("*************"+repeats);
        }
    }
}