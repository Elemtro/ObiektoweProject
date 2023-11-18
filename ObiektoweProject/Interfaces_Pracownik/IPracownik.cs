using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweProject.Interfaces_Pracownik
{
    internal interface IPracownik
    {
        string Login { get; set; }
        string Password { get; set; }
        string Imie { get; set; }
        string Nazwisko { get; set; }
        long Pesel { get; set; }
        string Stanowisko { get; set; }
    }
}
