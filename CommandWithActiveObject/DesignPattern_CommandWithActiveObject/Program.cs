
namespace DesignPattern_CommandWithActiveObject
{
    /// <summary>
    /// 多功能與多任務
    /// 使用Command模式與Active Object模式進行多工(多執行緒)指令。
    /// run-to-completion任務(RTC)，表示不會中途暫停(block)住，直到運行到完成。
    /// 缺點CPU時脈造成每次執行不會完美同步，結果會有不確定性(順序)。
    /// 
    /// 以下為兩次結果:
    /// 13571131151317113151131171531113115173111315113171153111311751311131511731115311131715137
    /// 13571131151317113151131171531113115173111315113171153111311571311131511731115311131715137
    /// </summary>
    class Program
    {
        public static ActiveObjectEngine Engine = new ActiveObjectEngine();

        public static void Main(string[] args)
        {
            Engine.AddCommand(new DelayedTyper(Engine, 100, '1'));
            Engine.AddCommand(new DelayedTyper(Engine, 300, '3'));
            Engine.AddCommand(new DelayedTyper(Engine, 500, '5'));
            Engine.AddCommand(new DelayedTyper(Engine, 700, '7'));

            // 停止所有DelayedTyper執行
            ICommand stopAllDelayedTyperCommand = new DelayedTyper.StopAllDelayedTyperCommand();
           
            // 延遲執行
            Engine.AddCommand(new SleepCommand(5000, Engine, stopAllDelayedTyperCommand));
            Engine.Run();
        }
    }
}
