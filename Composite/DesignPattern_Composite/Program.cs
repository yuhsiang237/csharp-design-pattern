using System;

namespace DesignPattern_Composite
{
    /// <summary>
    /// Composite模式
    /// 將物件組合成樹形結構以表示「 部分 - 整體 」的層次結構。
    /// 組合模式使得用戶對單個物件和組合物件的使用具有一致性。[ DP ]
    /// 組合模式主要的角色是元件介面和界面如何運用，讓各個元件組合成樹狀的結構。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Square s = new Square();
            Square s2 = new Square();

            CompositeShape compositeShape = new CompositeShape();
            compositeShape.Add(c);
            compositeShape.Add(s);
            compositeShape.Add(s2);

            compositeShape.Draw();

        }
    }
}
