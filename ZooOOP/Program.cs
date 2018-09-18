using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat k = new Kat();
            k.navn = "Molly";

            Dyr dyr = new Dyr();
            Dyr.tam = true;
            dyr.Tam, = true;
            dyr.Tam, = false;
            Console.WriteLine(dyr.tam);
            
            /*
            //1. hest
            // create instance of Hest
            Hest minHest = new Hest();
            Hest minAndenHest = new Hest();

            //Console.WriteLine("Hestens fødselsår?");
            //minHest.year = Convert.ToInt32(Console.ReadLine());


            //// use intance of Hest
            //Console.WriteLine("Indtast venligst hestenavn #1:");
            //minHest.navn = Console.ReadLine();
            ////minHest.navn = "Otto";
            //minHest.maxHastighed = 3.14159;
            minHest.Run();
            minAndenHest.Run();
            /*
            
            //2. Hest
            //Console.WriteLine("Indtast venligst hestenavn #2:");

            //minAndenHest.navn = Console.ReadLine();

            //minAndenHest.maxHastighed = minHest.maxHastighed * 3;
            //minAndenHest.Run();
            //Console.WriteLine("Hestens fødselsår?");
            //minAndenHest.year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hvad skal anden hest hedde?");
            //minAndenHest.navn = Console.ReadLine();
            //Console.WriteLine(minAndenHest.navn);


        }
    }
}
