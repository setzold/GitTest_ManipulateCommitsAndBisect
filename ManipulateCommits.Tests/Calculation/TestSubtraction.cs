using ManipulateCommits.Console.Calculation;
using NUnit.Framework;

namespace ManipulateCommits.Tests.Calculation
{
    [TestFixture]
    public class TestSubtraction
    {
        [Test]
        public void Test_Subtraction_with_9_minus_4_expects_5()
        {
            var testClass = new Subtraction();

            int result = testClass.Minus(9,4);

            Assert.AreEqual(5, result, "return value was not 5 !!!");
        }
    }
}
