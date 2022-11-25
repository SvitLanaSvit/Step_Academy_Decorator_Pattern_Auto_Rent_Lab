using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Decorator_Pattern_2
{
    public class ConcreteAuto : Auto
    {
        public override double Price { get; }

        public override double Distance { get; }

        public ConcreteAuto(double price, double distance) 
        {
            Price = price;
            Distance = distance;
        }
    }
}