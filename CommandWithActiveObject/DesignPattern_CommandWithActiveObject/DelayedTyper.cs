using System;

namespace DesignPattern_CommandWithActiveObject
{
    /// <summary>
    /// 延遲輸入命令
    /// </summary>
    class DelayedTyper:ICommand
    {
        private long _itsDelay;
        private char _itsChar;
        private static bool _stop = false;
        private ActiveObjectEngine _engine;
        public class StopAllDelayedTyperCommand : ICommand
        {
            /// <summary>
            /// 停止運行指令
            /// </summary>
            public void Execute()
            {
                DelayedTyper._stop = true;
            }
        }

        public DelayedTyper(ActiveObjectEngine engine,long delay,char c)
        {
            _itsDelay = delay;
            _itsChar = c;
            _engine = engine;
        }
        
        public void Execute()
        {
            Console.Write(_itsChar);
            if (!_stop)
            {   // 尚未終止則持續增加本身指令到Active Object Engine
                DelayAndRepeat(); 
            }
        }
        /// <summary>
        /// 反覆增加本身的指令添加延遲SleepCommand到Active Object Engine
        /// </summary>
        private void DelayAndRepeat()
        {
            _engine.AddCommand(new SleepCommand(_itsDelay, _engine, this));
        }
    }
}
