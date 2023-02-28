using System;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            int j = 2;


            int actual = 0;

            Xz sol = new Xz(i, j);
            int result = 0;

            Assert.AreEqual(actual, sol.Solution(result));
        }
    }
}
