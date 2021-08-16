using System;
using System.Text;

namespace CSVersionOfClassCoding
{
    public class SpacedLogger : ILogger
    {
        public void Log(string word)
        {
            var arr = word.ToCharArray();
            var build = new StringBuilder();
            foreach (char x in arr)
            {
                build.Append(x).Append(' ');
            }
            Console.WriteLine(build);
        }

        public void Error(string word)
        {
            var arr = word.ToCharArray();
            var build = new StringBuilder();
            foreach (char x in arr)
            {
                build.Append(' ').Append(x);
            }
            Console.WriteLine("ERROR:" + build);
        }
    }
}