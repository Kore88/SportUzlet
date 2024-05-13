using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportUzlet.Model
{
    class Termek
    {
        [Key]
        private int termekID;
        int egysegar;
        string termeknev;


        public int Egysegar { get => egysegar; set => egysegar = value; }
        public string TermekNev { get => termeknev; set => termeknev = value; }
        public int TermekID { get => termekID; set => termekID = value; }

        public Termek(string termeknev,int egysegar)
        {
            Egysegar = egysegar;
            TermekNev = termeknev;
        }
    }
}
