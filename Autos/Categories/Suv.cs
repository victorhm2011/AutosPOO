using Autos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autos.Categories
{
    class Suv : Car, IElectric
    {
        private string name { get; set; }

        public Suv(string n)
        {
            name = n;
        }
        public int SizeofBattery()
        {
            return 500;
        }

        public int TimeToCharge()
        {
            return 8;
        }
    }
}
