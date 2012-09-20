using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloLib
{
    public class Human
    {
        public string Name { get; set; }
        public string WriteHello()
        {
            return "Hi, I am " + Name;
        }
    }
}
