using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportUzlet.SQL
{
    class SQLCommands
    {
        public static string cmdAllSzemely = "SELECT nev, cim FROM sportuzlet.szemely";
        public static string cmdAllTermek = "SELECT termekNev, egysegar FROM sportuzlet.termekek";

    }
}
