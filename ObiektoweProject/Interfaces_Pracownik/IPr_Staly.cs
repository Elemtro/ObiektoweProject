using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweProject.Interfaces_Pracownik
{
    internal interface IPr_Staly : IPracownik
    {
        int Pensja_miesiac { get; set; }
        void Wakacje();
    }
}
