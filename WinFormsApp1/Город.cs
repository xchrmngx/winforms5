using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Город : Место
    {
        public string mayor;
        
        public Город(string mayor, string name, string population): base(name, population)
        {
            this.mayor = mayor;
        }

        public override string  Info()
        {
            return $"Название города: {name}, население: {population}, мэр города: {mayor}";
        }
    }
}
