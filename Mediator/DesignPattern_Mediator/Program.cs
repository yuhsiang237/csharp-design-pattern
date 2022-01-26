namespace DesignPattern_Mediator
{
    /// <summary>
    /// Mediator 中介者模式
    /// 確保了構件之間的鬆耦合，使得它們不直接調用彼此，
    /// 而是通過中介者調用彼此。 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            mediator.Component1 = new Component1();
            mediator.Component2 = new Component2();
            object o = new object();
            mediator.ChangeState(o);
        }
    }
}
