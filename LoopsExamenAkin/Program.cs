using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExamenAkin
{
    class Program
    {
        static void Main(string[] args)
        {
            //VRAAG 1


            int groot = 0,  getal;
            int i = 1;
            while ( i <= 3 )
            {
                Console.Write("{0}. Getal: ", i);
                getal = Convert.ToInt32(Console.ReadLine());
                i++;
                if (i == 1)
                {
                    groot = getal;
                    
                }
                
                if (groot < getal)
                { groot = getal; }

            }

            Console.WriteLine("Grootste Getal {0}", groot);
           
            Console.ReadLine();








        }
    }
}
