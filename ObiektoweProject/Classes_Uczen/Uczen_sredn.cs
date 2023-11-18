using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObiektoweProject.Interfaces_Uczen;

namespace ObiektoweProject.Classes_Uczen
{
    internal class Uczen_sredn : IUczen
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long Pesel { get; set; }
        public double Srednia { get; set; }
        public string Stanowisko { get; set; }

        public void Uczyc_sie()
        {

        }
        public void Zdawac_egzaminy()
        {

        }
    }
}
