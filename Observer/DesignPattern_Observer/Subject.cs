using System.Collections;

namespace DesignPattern_Observer
{
    public class Subject
    {
		// use array list implementation for collection of observers
		private ArrayList _observers;

		// constructor
		public Subject()
		{
			_observers = new ArrayList();
		}

		public void Register(IObserver observer)
		{
			// if list does not contain observer, add
			if (!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}
		}

		public void Deregister(IObserver observer)
		{
			// if observer is in the list, remove
			if (_observers.Contains(observer))
			{
				_observers.Remove(observer);
			}
		}

		public void Notify(string message)
		{
			// call update method for every observer
			foreach (IObserver observer in _observers)
			{
				observer.Update(message);
			}
		}
	}
}
