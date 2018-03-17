using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP.Tests
{
    [TestClass()]
    public class PrototypeTests
    {
        [TestMethod()]
        public void UnitTestTestTest()
        {
            var p = new Prototype();
            Assert.AreEqual(1, p.UnitTestTest());
        }
    }
}