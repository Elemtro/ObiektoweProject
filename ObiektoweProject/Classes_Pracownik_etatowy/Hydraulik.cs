using ObiektoweProject.Interfaces_Pracownik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweProject.Classes_Pracownik_etatowy
{
    internal class Hydraulik : IPr_Etatowy
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }
        public string Pensja_godzina { get; set;  } = "20 zl/g";
        public string Stanowisko { get; set; }

        public void ElastycznyGrafik()
        {
        }
        public void Naprawiac()
        {

        }
    }
}
