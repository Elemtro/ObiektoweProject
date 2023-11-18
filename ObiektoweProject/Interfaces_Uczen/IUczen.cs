using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweProject.Interfaces_Uczen
{
    internal interface IUczen
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        long Pesel { get; set; }
        double Srednia { get; set; }
        string Stanowisko { get; set; }
        void Uczyc_sie();
    }
}
