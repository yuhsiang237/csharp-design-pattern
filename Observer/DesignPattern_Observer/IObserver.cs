using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Observer
{
    // IObserver --> interface for the observer
    public interface IObserver
    {
        // called by the subject to update the observer of any change
        // The method parameters can be modified to fit certain criteria
        void Update(string message);
    }
}
