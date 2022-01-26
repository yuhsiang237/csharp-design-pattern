using DesignPattern_Singleton;
using NUnit.Framework;
using System;
using System.Reflection;

namespace DesignPattern_SingletonTests
{
    [TestFixture]
    public class TestSimpleSingleton
    {
        [Test]
        public void TestCreateSingleton()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1, s2);
        }

        [Test]
        public void TestNoPublicConstructors()
        {
            Type signleton = typeof(Singleton);
            ConstructorInfo[] ctrs = signleton.GetConstructors();
            bool hasPublicConstructor = false;
            foreach(ConstructorInfo c in ctrs)
            {
                if (c.IsPublic)
                {
                    hasPublicConstructor = true;
                    break;
                }
            }
            Assert.IsFalse(hasPublicConstructor);
        }
    }
}