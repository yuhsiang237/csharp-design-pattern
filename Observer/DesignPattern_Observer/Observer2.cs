using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Observer
{
    public class Observer2 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer2:" + message);
        }
    }
}
