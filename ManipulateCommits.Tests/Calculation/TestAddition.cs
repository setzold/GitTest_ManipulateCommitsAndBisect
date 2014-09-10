using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManipulateCommits.Console.Calculation;
namespace ManipulateCommits.Tests.Calculation
{
    [TestFixture]
    public class TestAddition
    {
        [Test]
        public void Test_Addition_with_4_plus_5_expects_9()
        {
            var testClass = new Addition();

            int result = testClass.Plus(4, 5);

            Assert.AreEqual(9, result, "return value was not 9 !!!");
        }

        [Test]
        public void Test_Addition_with_4point3_plus_5point4_expects_9point7()
        {
            var testClass = new Addition();

            decimal result = testClass.Plus(4.3m, 5.4m);

            Assert.AreEqual(9.7, result, "return value was not 9.7 !!!");
        }
    }
}
