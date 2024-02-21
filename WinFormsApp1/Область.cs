using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Область : Место
    {
        public string area;
        public Область(string population, string name, string area) : base (name, population)
        {
            this.area = area;
        }
        public override string Info()
        {
            return $"Название области:{name}, население: {population}, площадь: {area}";
        }
    }
}
