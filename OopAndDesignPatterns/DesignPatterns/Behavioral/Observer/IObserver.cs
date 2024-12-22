using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Behavioral.Observer
{
    internal interface IObserver //The one who observes the Observable(In this case the Subject is an Observable) And each of it's child can have their concrete implementation of IObserver. For eg: School can have different imp and User can have diff. Imp.
    {
        void Update(string news); //For the Subject to update to Observers that the state is updated
    }
}
