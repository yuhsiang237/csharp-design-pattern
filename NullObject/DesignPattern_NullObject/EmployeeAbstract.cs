using System;

namespace DesignPattern_NullObject
{
    public abstract class EmployeeAbstract
    {
        public abstract bool IsTimeToPay(DateTime time);
        public abstract void Pay();
        public static readonly EmployeeAbstract NULL = new NullEmployee();
        /// <summary>
        /// NullEmployee 為內嵌類別，確保該類別只有單一實例，其他類別不能建立NullEmployee實例
        /// </summary>
        private class NullEmployee : EmployeeAbstract
        {
            public override bool IsTimeToPay(DateTime time)
            {
                return false;
            }

            public override void Pay()
            {
                Console.WriteLine("Pay");
            }
        }

    }
}
