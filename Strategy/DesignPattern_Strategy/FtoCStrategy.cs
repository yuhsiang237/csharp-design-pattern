using System;
using System.IO;

namespace DesignPattern_Strategy
{
    class FtoCStrategy:IApplication
    {
        private TextReader _input;
        private TextWriter _output;
        private bool _isDone = false;

        public void CleanUp()
        {
            _output.WriteLine("ftoc exit");
        }

        public bool Done()
        {
            return _isDone;
        }

        public void Idle()
        {
            string fahrString = _input.ReadLine();
            if(fahrString == null || fahrString.Length == 0)
            {
                _isDone = true;
            }
            else
            {
                double fahr = Double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                _output.WriteLine("F={0}, C={1}", fahr, celcius);
            }
        }

        public void Init()
        {
            _input = Console.In;
            _output = Console.Out;
        }
    }
}
