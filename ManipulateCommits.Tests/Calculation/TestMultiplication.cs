using ManipulateCommits.Console.Calculation;
using NUnit.Framework;

namespace ManipulateCommits.Tests.Calculation
{
    [TestFixture]
    public class TestMultiplication
    {
        [Test]
        public void Test_Multiply_4_by_5_expects_20()
        {
            var testClass = new Multiplication();

            int result = testClass.Multiply(4, 5);

            Assert.AreEqual(20, result, "return value was not 20 !!!");
        }
    }

}
