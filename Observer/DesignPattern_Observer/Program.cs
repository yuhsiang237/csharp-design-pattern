using System;

namespace DesignPattern_Observer
{
    /// <summary>
    /// Observer觀察者模式
    /// 是軟體設計模式的一種。
    /// 在此種模式中，"一個目標物件管理所有相依於它的觀察者物件"，
    /// 並且在它本身的狀態改變時主動發出通知。
    /// 這通常透過呼叫各觀察者所提供的方法來實現。
    /// 此種模式通常被用來實時事件處理系統。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Subject mySubject = new Subject();
            IObserver myObserver1 = new Observer1();
            IObserver myObserver2 = new Observer2();
            IObserver myObserver3 = new Observer3();

            // register observers
            mySubject.Register(myObserver1);
            mySubject.Register(myObserver2);
            mySubject.Register(myObserver3);
            
            // remove register observers
            mySubject.Deregister(myObserver2);

            mySubject.Notify("message 1");
            mySubject.Notify("message 2");
            mySubject.Notify("message 3");

        }
    }
}
