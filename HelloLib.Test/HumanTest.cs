using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloLib.Test
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void TestWriteHello()
        {
            var human = new Human
            {
                Name = "Ding",
            };

            Assert.AreEqual("Hi, I am Ding", human.WriteHello());
        }
    }
}
