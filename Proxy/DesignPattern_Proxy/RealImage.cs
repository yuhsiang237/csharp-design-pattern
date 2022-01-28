using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Proxy
{
    class RealImage : IImage
    {
        public String FileName { get; private set; }
        public RealImage(string fileName)
        {
            FileName = fileName;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            Console.WriteLine("Loading " + FileName);
        }
        public void Display()
        {
            Console.WriteLine("Displaying " + FileName);
        }
    }
}
