using NUnit.Framework;
using src.Questions.Numers;

namespace tests.Questions {
    public class NumbersTest {
        [Test]
        public void PowerOfThree_326Test () {
            var expected = false;

            var acutal = PowerOfThree_326.IsPowerOfThree (45);

            Assert.AreEqual (acutal, expected);
        }

        [Test]
        public void PowerOfOneBit_191Test () {
            var expected = 3;

            var acutal = PowerOfOneBit_191.HammingWeight (11);

            Assert.AreEqual (acutal, expected);
        }
    }
}