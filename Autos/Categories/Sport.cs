using Autos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autos.Categories
{
    class Sport : Car, IGas
    {
        private string name { get; set; }

        private string turbo { get; set; }

        public Sport (string n)
        {
            name = n;
        }
        void IGas.Maintenance()
        {
            turbo = "Ready to run";
        }

        int IGas.MPG()
        {
            return 20;
        }
    }
}
