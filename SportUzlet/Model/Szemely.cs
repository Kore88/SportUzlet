using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportUzlet.Model
{
    class Szemely
    {

        string cim;
        string nev;

        public string Cim { get => cim; set => cim = value; }
        public string Nev { get => nev; set => nev = value; }

        public Szemely(string cim, string nev)
        {
            Cim = cim;
            Nev = nev;
        }
    }
}
