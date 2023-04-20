using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria um produto sem estoque e exibe disponibilidade

            ConcreteSubject IPhone11 = new ConcreteSubject("IPhone 11 ", 4900, "Sem Estoque");
            Console.WriteLine("IPhone 11 - estado atual : " + IPhone11.GetDisponibilidade());

            Console.WriteLine("\nObservers inscritos para receber notificações sobre " +
                "o produto IPhone 11\n");

            //cria Usuario Macoratti e registra objeto no Subject

            ConcreteObserver macoratti = new ConcreteObserver("Macoratti", IPhone11);

            //cria Usuario Miriam e registra objeto no Subject

            ConcreteObserver miriam = new ConcreteObserver("Miriam", IPhone11);

            //cria Usuario Janice e registra objeto user1 no Subject

            ConcreteObserver janice = new ConcreteObserver("Janice", IPhone11);

            Console.WriteLine("\nPressione algo para alterar a disponibilidade e " +
                "notificar os observers\n");
            Console.ReadKey();

            //altera status do Subject e notifica observers

            IPhone11.SetDisponibilidade("Disponível");

            Console.Read();
        }
    }
}
