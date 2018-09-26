using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FizzBuzz
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
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.Read();
        }
    }
}
