using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloJenkins
{
    public static class Program
    {
        private static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hello Jenkins! " + i);
            }

            Console.ReadLine();
        }
    }
}
