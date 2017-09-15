using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;

namespace UT1LR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            HomeController hc = new HomeController();

            //act
            int result = hc.ResponseCode();

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
