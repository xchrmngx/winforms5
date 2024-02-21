using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class Мегаполис : Город
    {
        public string Skyscrapers;

        public Мегаполис(string skyscrapers, string name, string population, string mayor) : base (name, population, mayor)
        {
            this.Skyscrapers = skyscrapers;
        }
        public override string Info()
        {
            return $"Название мегаполиса: {name}, население: {population}, количество небоскрёбов: {Skyscrapers}";
        }
    }
}
