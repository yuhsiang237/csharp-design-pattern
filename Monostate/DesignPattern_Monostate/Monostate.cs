using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Monostate
{
    public class Monostate
    {
        private static int _itsX;
        public int X
        {
            get { return _itsX; }
            set { _itsX = value; }
        }
    }
}
