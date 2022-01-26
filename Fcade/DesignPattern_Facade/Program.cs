namespace DesignPattern_Facade
{
    /// <summary>
    /// Facade模式，指對於一組「複雜且通用的介面」，提供一個「簡單且特定的介面」。
    /// 指開發人員接受了所有呼叫都必須透過「簡單且特定的介面」。
    /// 從上施加規約，具備可見、強制性。
    /// 常見的作法是用來隱藏資料庫。
    /// 在此範例facade分別提供兩個簡單的特定的介面，操作內部不同子系統類別的程式。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

        }
    }
}
