using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEx2
{
    public interface ISubject
    {
        void RegistrarObserver(IObserver observer);
        void RemoverObserver(IObserver observer);
        void NotificarObservers();
    }
}
