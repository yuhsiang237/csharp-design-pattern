using System;

namespace DesignPattern_Monostate
{
    /// <summary>
    /// Monostate模式
    /// 獲取物件單一性的模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Monostate m1 = new Monostate();
            Monostate m2 = new Monostate();
            m2.X = 100;
            Console.WriteLine("m1={0} ",m1.X);
            Console.WriteLine("m2={0} ",m2.X);
        }
    }
}
