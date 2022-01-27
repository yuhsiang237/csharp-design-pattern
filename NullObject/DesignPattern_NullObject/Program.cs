using System;

namespace DesignPattern_NullObject
{
    /// <summary>
    /// Null Object模式
    /// 可以確保函式總是回傳有效物件，使得檢查NULL不再需要、有利簡化程式碼
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAbstract e = DB.GetEmployee();
            if(e.IsTimeToPay(new DateTime()))
            {
                e.Pay();
            }
        }
    }
}
