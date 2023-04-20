using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEx2
{
    public interface IObserver
    {
        void Atualiza(string disponibilidade);
    }
}
