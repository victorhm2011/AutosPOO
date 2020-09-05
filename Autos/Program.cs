using Autos.Categories;
using System;

namespace Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan corolla = new Sedan("corolla");

            corolla.Transport("Cochabamba", "La Paz");

            Console.WriteLine(corolla.SizeofBattery());

        }
    }
}
