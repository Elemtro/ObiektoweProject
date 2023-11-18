using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweProject.Interfaces_Pracownik
{
    internal interface IPr_Etatowy : IPracownik
    {
        string Pensja_godzina { get; set; }
        void ElastycznyGrafik();
    }
}
