using DesignPattern_Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPattern_FactoryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateCircle()
        {
            IShapeFactory shapeFactory = new ShapeFactoryImplementation();
            IShape s = shapeFactory.Make("Circle");
            Assert.IsTrue(s is Circle);
        }
        [TestMethod]
        public void TestCreateSquare()
        {
            IShapeFactory shapeFactory = new ShapeFactoryImplementation();
            IShape s = shapeFactory.Make("Square");
            Assert.IsTrue(s is Square);
        }
    }
}
