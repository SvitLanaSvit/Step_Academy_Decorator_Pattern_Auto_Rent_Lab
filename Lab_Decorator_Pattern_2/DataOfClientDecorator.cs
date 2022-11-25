using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Decorator_Pattern_2
{
    public class DataOfClientDecorator : AutoDecorator
    {
        private readonly string name;
        private readonly string surname;
        private readonly string pass;
        public DataOfClientDecorator(Auto auto, string name, string surname, string pass) : base(auto)
        {
            this.name = name;
            this.surname = surname;
            this.pass = pass;
        }

        public override string ToString()
        {
            return $"Rented by: \n\t\t{name}\n\t\t{surname}\n\t\t{pass}";
        }
    }
}
