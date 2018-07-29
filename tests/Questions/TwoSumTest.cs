using NUnit.Framework;

namespace tests.Questions {
    public class TwoSum_1Test {
        [Test]
        public void ReturnFalseGivenValueOf1 () {
            var result = _primeService.IsPrime (1);

            Assert.IsFalse (result, "1 should not be prime");
        }
    }
}