using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    public class ShapeFactoryImplementation : IShapeFactory
    {
        public IShape Make(string name)
        {
            if (name.Equals("Circle"))
            {
                return new Circle();
            }
            else if (name.Equals("Square"))
            {
                return new Square();
            }
            else
            {
                throw new Exception("ShapeFactory cannot create:"+name);
            }
        }
    }
}
