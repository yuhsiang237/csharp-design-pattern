using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Proxy
{
    class ProxyImage : IImage
    { 
        public String FileName { get; private set; }

        private IImage _image;

        public ProxyImage(string fileName)
        {
            FileName = fileName;
        }
        public void Display()
        {
            if (_image == null)
                _image = new RealImage(FileName);
            _image.Display();
        }
    }

}
