using System;

namespace DesignPattern_TemplateMethod
{
    /// <summary>
    /// Template Method設計模式
    /// 主要使用"繼承"方式拆出通用演算法
    /// 將核心邏輯寫在抽象類別(abstract class)，底層class再用繼承去實作
    /// 以下以氣泡排序為例子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DoubleBubbleSorter dbs = new DoubleBubbleSorter();
            double[] array = new double[] { 1.5f, -15.1f, 1.4f, 2.6f, 3f };
            dbs.Sort(array);
            foreach(double item in array)
            {
                Console.Write("{0} ",item);
            }
        }
    }
}
