using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Behavioral.Observer
{
    internal class NewsAgency : ISubject //Concrete Implementation of the Observable
    {
        private List<IObserver> _observers = [];
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(string news)
        {
            foreach (var observer in _observers)
            {
                observer.Update(news);
            }
        }


    }
}
