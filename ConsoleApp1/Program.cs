using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string limit = Console.ReadLine();
            uint limitConvert = uint.Parse(limit);
            if (limitConvert > 0)
            {
                for (uint i = 1; i <= limitConvert; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Trace.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Trace.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Trace.WriteLine("Buzz");
                    }
                    else
                    {
                        Trace.WriteLine(i);
                    }
                }
            }
        }
    }
}
