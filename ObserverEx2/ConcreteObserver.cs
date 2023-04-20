using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEx2
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }
        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistrarObserver(this);
        }

        public void Atualiza(string disponibilidade)
        {
            Console.WriteLine($"Olá {Usuario}, o Produto que você deseja agora " +
                $"esta {disponibilidade} em nosso site");
        }
    }
}
