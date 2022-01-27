using NUnit.Framework;
using DesignPattern_Observer;
using System;
using System.Diagnostics;
using System.IO;

namespace DesignPattern_ObserverTests
{
    public class Tests
    {

        [Test]
        public void TestObserverOutput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
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

                string expected = 
                    "Observer1:message 1\r\n" +
                    "Observer3:message 1\r\n" +
                    "Observer1:message 2\r\n" +
                    "Observer3:message 2\r\n" +
                    "Observer1:message 3\r\n" +
                    "Observer3:message 3\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}