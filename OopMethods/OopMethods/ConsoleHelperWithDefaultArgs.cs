using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class ConsoleHelperWithDefaultArgs
    {
        public static void Print(string message, string label="", int count=1)
        {
            if(!string.IsNullOrEmpty(label))
            {
                Console.WriteLine($"{label}: ");
            }
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
