namespace DesignPattern_Mediator
{
    /// <summary>
    /// Mediator
    /// 在下面的例子中，調解人註冊了所有的構件
    /// 然後調用了它們的SetState方法。
    /// </summary>
    class Mediator
    {
        public IComponent Component1 { get; set; }
        public IComponent Component2 { get; set; }

        public void ChangeState(object state)
        {
            Component1.SetState(state);
            Component2.SetState(state);
        }
    }
}
