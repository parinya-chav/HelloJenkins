﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace HelloLib.Test
{
    using MbUnit.Framework;

    public class HumanTest
    {
        [Test]
        public void TestWriteHello()
        {
            var human = new Human
            {
                Name = "Ding",
            };

            string writeHello = human.WriteHello();
            Assert.AreEqual("Hi, I am Ding", writeHello);
        }
    }
}
