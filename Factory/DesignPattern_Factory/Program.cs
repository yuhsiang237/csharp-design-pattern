using System;

namespace DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapeFactory shapeFactory = new ShapeFactoryImplementation(); // 建立工廠
            // 利用工廠內部方法去產生實體
            IShape circle = shapeFactory.Make("Circle"); 
            IShape square = shapeFactory.Make("Square");
            
            Console.WriteLine(circle.getName());
            Console.WriteLine(square.getName());
        }
    }
}
