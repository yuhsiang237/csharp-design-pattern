using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Singleton
{
    public class Singleton
    {
        private static Singleton _theInstance = null;

        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                if(_theInstance == null) // 僅實例一次
                {
                    _theInstance = new Singleton();
                }
                return _theInstance;
            }
        }
    }
}
