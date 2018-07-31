using NUnit.Framework;
using src.Questions.Numers;

namespace tests.Questions
{
    public class PowerOfThree_326Test
    {
        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            var expected = false;

            var acutal = PowerOfThree_326.IsPowerOfThree(45);

            Assert.AreEqual(acutal, expected);
        }
    }
}