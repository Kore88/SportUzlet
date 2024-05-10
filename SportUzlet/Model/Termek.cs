using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportUzlet.Model
{
    class Termek
    {
        int egysegar;
        string termeknev;


        public int Egysegar { get => egysegar; set => egysegar = value; }
        public string Termeknev { get => termeknev; set => termeknev = value; }

        public Termek(string termeknev,int egysegar)
        {
            Egysegar = egysegar;
            Termeknev = termeknev;
        }
    }
}
