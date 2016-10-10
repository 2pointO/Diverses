using Microsoft.VisualStudio.TestTools.UnitTesting;
using module3Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3Exercise1.Tests
{
    [TestClass()]
    public class AlgoTests
    {
        [TestMethod()]
        public void FindGCDEuclidTest()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;
            int actual;
            long time = 0;
            Algo Algo = new Algo();
            actual = Algo.FindGCDEuclid(a, b,out time);
            Assert.AreEqual(expected, actual);
        }
    }
}