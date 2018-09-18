using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Hest: Dyr
    {
        //Maxhastighed måles i km/t
        public double maxHastighed;
        public Hest()
        {
            Console.WriteLine("Indtast venligst hestenavn:");
            navn = Console.ReadLine();
            Console.WriteLine("Hestens fødselsår?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er du?");
            maxHastighed = Convert.ToDouble(Console.ReadLine());
        }

        private void Eat()
        {
            Console.WriteLine("Gnaske gnaske ...");
        }

        public void Run()
        {
            if (2018 - year <= 1)
            {
                Console.WriteLine("Weeeeeee");
            }
            else
            {
                Console.WriteLine("Wrinske wrinske");
            }

            Console.Write("Wrinske wrinske");
            Console.Write("Med en maxhastighed på ");
            Console.Write(maxHastighed);
            Console.WriteLine(" km/t ");
            Console.WriteLine("Wrinske-hilsen " + navn);
            Console.WriteLine("Jeg er" + (2018-year) + "år gammel");  

            Eat();
        }
    }
}
