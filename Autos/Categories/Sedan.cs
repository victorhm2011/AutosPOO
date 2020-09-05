using Autos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autos.Categories
{
    class Sedan : Car, IElectric
    {
        private string name { get; set; }

        public Sedan(string  n)
        {
            name = n;
        }

        public int SizeofBattery()
        {
            return 450;
        }

        public int TimeToCharge()
        {
            return 8;
        }
    }
}
