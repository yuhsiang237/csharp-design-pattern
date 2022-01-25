using DesignPattern_CommandWithActiveObject;
using NUnit.Framework;
using System;

namespace DesignPattern_CommandWithActiveObjectTests
{
    [TestFixture]
    public class TestSleepCommand
    {
        private class WakeUpCommand : ICommand
        {
            public bool executed = false;
            public void Execute()
            {
                executed = true;
            }
        }

        /// <summary>
        /// 測試SleepCommand
        /// </summary>
        [Test]
        public void TestSleep()
        {
            WakeUpCommand wakeup = new WakeUpCommand();
            ActiveObjectEngine e = new ActiveObjectEngine();
            SleepCommand c = new SleepCommand(1000, e, wakeup);
            e.AddCommand(c);
            DateTime start = DateTime.Now;
            e.Run();
            DateTime stop = DateTime.Now;
            double sleepTime = (stop - start).TotalMilliseconds;
            Assert.IsTrue(sleepTime >= 1000, "SleepTime " + sleepTime + " expected > 1000");
            Assert.IsTrue(sleepTime <= 1100, "SleepTime " + sleepTime + " expected < 1100");
            Assert.IsTrue(wakeup.executed, "Command Executed");
        }
    }
}
