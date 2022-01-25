using System;

namespace DesignPattern_CommandWithActiveObject
{
    /// <summary>
    /// 延遲執行
    /// </summary>
    public class SleepCommand : ICommand
    {
        private ICommand _wakeupCommand = null;
        private ActiveObjectEngine _engine = null;
        private long _sleepTime = 0;
        private DateTime _startTime;
        private bool _started = false;
        
        /// <summary>
        /// 建構延遲指令
        /// </summary>
        /// <param name="milliseconds">毫秒</param>
        /// <param name="e">Active Obejct Engine</param>
        /// <param name="wakeupCommnad">延遲後執行的指令</param>
        public SleepCommand(long milliseconds,ActiveObjectEngine e,ICommand wakeupCommnad)
        {
            _sleepTime = milliseconds;
            _engine = e;
            _wakeupCommand = wakeupCommnad;
        }

        /// <summary>
        /// 延遲執行
        /// 使用共用同一個執行堆疊的方法
        /// </summary>
        public void Execute()
        {
            DateTime currentTime = DateTime.Now;
            if (!_started)
            {   
                _started = true;// 啟動
                _startTime = currentTime; // 設定目前時間
                _engine.AddCommand(this); // 增加一筆自身指令到Active Object Engine裡繼續等待
            }
            else
            {
                TimeSpan elapsedTime = currentTime - _startTime; // 計算經過時間
                if(elapsedTime.TotalMilliseconds < _sleepTime)
                {
                    _engine.AddCommand(this); // 增加一筆自身指令到Active Object Engine裡繼續等待
                }
                else
                {
                    _engine.AddCommand(_wakeupCommand); // 執行延遲後執行的指令
                }
            }
        }
    }
}
