using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
