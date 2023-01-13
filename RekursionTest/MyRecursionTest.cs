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
        public void RercursionFakultätTest_RecursionOf3x2x1()
        {
            MyRecursion mr = new MyRecursion();
            int rekursiontest = mr.Fakultät_Recursive(3);
            Assert.AreEqual(6, rekursiontest);
        }
        [Test]
        public void RercursionFakultätTest_RecursionOf4x3x2x1()
        {
            MyRecursion mr = new MyRecursion();
            int rekursiontest = mr.Fakultät_Recursive(4);
            Assert.AreEqual(24, rekursiontest);
        }
    }
}