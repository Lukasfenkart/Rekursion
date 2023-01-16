using NUnit.Framework;
using Rekursionen;

namespace RekursionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void RercursionFakultätTest_RecursionOfNumber_RecursionEqualsNumberTimesNumberMinusOne()
        {
            MyRecursion mr = new MyRecursion();
            int rekursiontest1 = mr.Fakultät_Recursive(3);
            int rekursiontest2 = mr.Fakultät_Recursive(4);
            Assert.AreEqual(6, rekursiontest1);
            Assert.AreEqual(24, rekursiontest2);
        }
        [Test]
        public void RercursionFibonacciTest_RecursionOfFibonacciNumber_RecursionEqualsNumberMinusTwoPlusNumberMinusOne()
        {
            FibonacciRecursion mr = new FibonacciRecursion();
            int rekursiontest1 = mr.Fibonacci_Recursive(5);
            int rekursiontest2 = mr.Fibonacci_Recursive(6);
            int rekursiontest3 = mr.Fibonacci_Recursive(7);
            Assert.AreEqual(5, rekursiontest1);
            Assert.AreEqual(8, rekursiontest2);
            Assert.AreEqual(13, rekursiontest3);
        }
    }
}