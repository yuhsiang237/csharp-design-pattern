using System.Collections;

namespace DesignPattern_Composite
{
    /// <summary>
    /// CompositeShape
    /// Composite：可以添加其他元件的元件(Collection of Components)
    /// </summary>
    class CompositeShape : IShape
    {
        private ArrayList _shapes = new ArrayList();
        public void Add(IShape s)
        {
            _shapes.Add(s);
        }
        public void Draw()
        {
            foreach (IShape shape in _shapes)
            {
                shape.Draw();
            }
        }
    }
}
