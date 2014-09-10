using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManipulateCommits.Console.Calculation;
namespace ManipulateCommits.Tests.Calculation
{
    [TestFixture]
    public class TestAdd
    {
        [Test]
        public void Test_Add_with_4_plus_5_expects_9()
        {
            var testClass = new Add();

            int result = testClass.Plus(4, 5);

            Assert.AreEqual(9, result, "return value was not 9 !!!");
        }
    }
}
