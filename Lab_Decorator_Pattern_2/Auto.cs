using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Decorator_Pattern_2
{
    public abstract class Auto
    {
        public string Title { get; init; } = null!;
        public string Model { get; init; } = null!;
        public string NumberRegistration { get; init; } = null!;
        public abstract double Price{ get; }
        public abstract double Distance { get; }

        public override string ToString()
        {
            return $"{Title},\t{Model},\t{NumberRegistration},\t{String.Format("{0:0.00}", Price)} Euro,\t{String.Format("{0:0.00}", Distance)} km";
        }
    }
}