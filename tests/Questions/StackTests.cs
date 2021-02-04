namespace tests.Questions {
    using NUnit.Framework;
    using src.Questions.StackTests;

    public class StackTests {

        // 155. Min Stack
        // https://leetcode.com/problems/min-stack/
        [Test]
        public void MinStackTest () {
            MinStack obj = new MinStack ();
            obj.Push (2);
            obj.Push (0);
            obj.Push (3);
            obj.Push (0);
            obj.GetMin ();
            obj.Pop ();
            obj.GetMin ();
            obj.Pop ();
            obj.GetMin ();
            obj.Pop ();
            var min = obj.GetMin ();
        }
    }
}