using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Behavioral.Observer
{
    internal interface ISubject //This is the Observable 
    {
        void RegisterObserver(IObserver observer); //To add a new Observer/Subscriber
        void UnregisterObserver(IObserver observer); //To remove an existing Observer
        void NotifyObservers(string news); //To notify about the state changes to all the observers
    }
}
