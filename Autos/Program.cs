using Autos.Categories;
using System;

namespace Autos
{
    class Program
    {

        static void Main(string[] args)
        {
            // aqui se crea un auto pero de tipo sedan
            Sedan corolla = new Sedan("corolla");
            Suv rav4 = new Suv("rav4");

            corolla.Transport("Cochabamba", "La Paz");

            corolla.Recharge(100);

            //De acuerdo a que tipo de auto es mostrara el tamaño de la bateria

            Console.WriteLine("Size of corolla");
            Console.WriteLine(corolla.SizeofBattery());

            Console.WriteLine("Size of rav4");
            Console.WriteLine(rav4.SizeofBattery());



        }
    }
}
