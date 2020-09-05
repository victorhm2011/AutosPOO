using System;
using System.Collections.Generic;
using System.Text;

namespace Autos
{
    class Car
    {
        protected int seats;
        protected int doors;
        protected int model;
        protected string brand;
        protected int fuel;
        public int price;

        protected void Transport(string origin, string destiny)
        {
            Console.WriteLine("You traveled from "+ origin + " to " + destiny);
        }

        protected void Recharge(int quantity)
        {
            fuel = fuel + quantity;
        }
        
    }
}
