using System;

namespace DesignPattern_Singleton
{
    /// <summary>
    /// Singleton模式
    /// 只有一個實例，程式被啟動時建立出來，直到關閉才被刪除。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
            if(ReferenceEquals(singleton1, singleton2))
            {
                Console.WriteLine("SameReference");
            }
        }
    }
}
