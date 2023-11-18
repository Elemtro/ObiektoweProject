using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using ObiektoweProject.Interfaces_Pracownik;

namespace ObiektoweProject.Classes_Pracownik
{
    internal class Nauczyciel : IPr_Staly
    {
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string Imie { get; set; } = "";
        public string Nazwisko { get; set; } = "";
        public int Pensja_miesiac { get; set; } = 4500;
        public long Pesel { get; set; } = 0;
        public string Stanowisko { get; set; } = "";
        public void Uczyc() { }
        public void Wakacje() { }
    }
}
