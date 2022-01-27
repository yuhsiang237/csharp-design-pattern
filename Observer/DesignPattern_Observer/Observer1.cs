using System;

namespace DesignPattern_Observer
{
    public class Observer1:IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer1:" + message);
        }
    }
}
