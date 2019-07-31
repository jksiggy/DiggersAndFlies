using System;
using System.Collections.Generic;

namespace DiggersAndFlies
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IFlyable> flyers = new List<IFlyable>();
            
            var parakeet = new Parakeets();
            var finche = new Finches();

            flyers.Add(parakeet);
            flyers.Add(finche);

            


        }

    }
}
