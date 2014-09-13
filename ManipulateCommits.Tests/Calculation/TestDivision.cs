using ManipulateCommits.Console.Calculation;
using NUnit.Framework;

namespace ManipulateCommits.Tests.Calculation
{
    [TestFixture]
    public class TestDivision
    {
        [Test]
        public void Test_Divide_20_by_5_expects_4()
        {
            var testClass = new Division();

            decimal result = testClass.divided(20, 5);

            Assert.AreEqual(4, result, "return value was not  4!!!");
        }
    }
}
