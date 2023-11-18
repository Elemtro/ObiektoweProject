using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObiektoweProject.Interfaces_Pracownik;

namespace ObiektoweProject.Classes_Pracownik
{
    internal class Lekarz : IPr_Staly
    {
        public int Pensja_miesiac { get; set; } = 5000;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }
        public string Stanowisko { get; set; }

        public void Leczyc() { }
        public void Wakacje() { }
    }
}
