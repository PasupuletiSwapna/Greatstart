using Microsoft.VisualStudio.TestTools.UnitTesting;
using unittestEX.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestEX.cs.Tests
{
    [TestClass()]
    public class productTests
    {
        [TestMethod()]
        public void SayhelloTest()
       {
            //Arrange
            var currentprod = new product();
            currentprod.ProdId = 1;
            currentprod.Prname = "saw";
            currentprod.Desc = "15-inch steel blade hand saw";
            var expected = "Hellosaw(1):15-inch steel blade hand saw";



            //Act

            var actual = currentprod.Sayhello();


            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}