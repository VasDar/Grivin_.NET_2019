using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 999; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    num += i;
                }

            }
            Console.WriteLine(num);
            Console.ReadKey();
           
        }
    }
}
