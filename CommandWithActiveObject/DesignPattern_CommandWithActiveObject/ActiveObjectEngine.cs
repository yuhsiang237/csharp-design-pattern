using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_CommandWithActiveObject
{
    /// <summary>
    /// Active Object模式。
    /// 可實作多執行緒控制，提供多工核心。
    /// </summary>
    public class ActiveObjectEngine
    {
        ArrayList itsCommands = new ArrayList();
        /// <summary>
        /// 添加指令
        /// </summary>
        /// <param name="c"></param>
        public void AddCommand(ICommand c)
        {
            itsCommands.Add(c);
        }
        /// <summary>
        /// 執行指令直到沒有任何指令
        /// 共用同一個堆疊
        /// </summary>
        public void Run()
        {
            while (itsCommands.Count > 0)
            {
                ICommand c = (ICommand)itsCommands[0];
                itsCommands.RemoveAt(0);
                c.Execute();
            }
        }
    }
}
