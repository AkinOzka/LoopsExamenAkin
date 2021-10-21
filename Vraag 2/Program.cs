using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // VRAAG 2


            //naam van student
            //punten voor Engels
            //programatie en netwerken

            int puntE;
            int puntP;
            int puntN;
            int sum;
            double gemiddelde;
            int punt = 0;

            do
            {
                Console.WriteLine("Voer de naam van de student");
                string naam = Console.ReadLine();
                Console.WriteLine("Voer de punt voor Engels");
                puntE = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Voer de punt voor Programatie");
                puntP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Voer de punt voor Netwerken");
                puntN = Convert.ToInt32(Console.ReadLine());

                sum = puntE + puntP+ puntN;
                gemiddelde = (puntE + puntP+puntN) / 3;


            } while (punt!=0);

            Console.WriteLine("Totaal van de punten: {0}", sum);
            Console.WriteLine("Gemiddelde van de punten: {0}", gemiddelde);

            Console.ReadLine();
        }
    }
}
