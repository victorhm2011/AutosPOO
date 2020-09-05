using Autos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autos.Categories
{
    class PickUp : Car, IGas
    {
        private string name { get; set; }

        private string cargoSize { get; set; }



        public PickUp(string n)
        {
            name = n;

        }

        public void Maintenance()
        {
            cargoSize = "ReadyToWork";
        }

        public int MPG()
        {
            return 18;
        }
    }
}
