using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Decorator_Pattern_2
{
    public class AutoDecorator : Auto
    {
        protected Auto auto;

        public AutoDecorator(Auto auto) //????
        {
            this.auto = auto;
            Title = auto.Title;
            Model = auto.Model;
            NumberRegistration = auto.NumberRegistration;
        }

        public override double Price => auto.Price;

        public override double Distance => auto.Distance;
    }
}
