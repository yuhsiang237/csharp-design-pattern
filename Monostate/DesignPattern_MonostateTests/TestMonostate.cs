using DesignPattern_Monostate;
using NUnit.Framework;

namespace DesignPattern_MonostateTests
{
    [TestFixture]
    public class TestMonostate
    {
        [Test]
        public void TestInstance()
        {
            Monostate m = new Monostate();
            for(int x = 0; x < 10; x++)
            {
                m.X = x;
                Assert.AreEqual(x, m.X);
            }
        }

        [Test]
        public void TestInstanceBehaveAsOne()
        {
            Monostate m1 = new Monostate();
            Monostate m2 = new Monostate();

            for (int x = 0; x < 10; x++)
            {
                m1.X = x;
                Assert.AreEqual(x, m2.X);
            }
        }
    }
}