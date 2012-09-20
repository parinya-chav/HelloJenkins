using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloLib;

namespace HelloJenkins
{
    public static class Program
    {
        private static void Main()
        {
            var jenkins = new Human
            {
                Name = "Jenkins"
            };
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(jenkins.WriteHello() + i);
            }

            Console.ReadLine();
        }
    }
}
