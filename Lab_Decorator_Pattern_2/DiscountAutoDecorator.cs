using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Decorator_Pattern_2
{
    public class DiscountAutoDecorator : AutoDecorator
    {
        private readonly int discount;
        private readonly double maxDistance;
        public DiscountAutoDecorator(Auto auto, int discount, double maxDistance) : base(auto)
        {
            this.discount = discount;
            this.maxDistance = maxDistance;
        }

        public override double Price => auto.Price - auto.Price * discount / 100.0;
        public override double Distance => auto.Distance + auto.Distance * maxDistance / 100.0;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}