using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Место
    {
        public string name;
        public string population;
        public Место(string name, string population)
        {
            this.name = name;
            this.population = population;
        }
        public virtual string Info()
        {
            return $"Место: {name}, население: {population}.";
        }
    }
}
