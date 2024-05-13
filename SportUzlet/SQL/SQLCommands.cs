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

        public static string cmdUpdateSzemely = "UPDATE sportuzlet.szemely SET szemely.nev=@nev, szemely.cim=@cim WHERE id=@id";
        public static string cmdUpdateTermek = "UPDATE sportuzlet.termekek SET termekek.termekNev=@termekNevev, termekek.egysegar=@egysegar WHERE id=@id";

        public static string cmdDeleteSzemely = "DELETE FROM sportuzlet.szemely WHERE id=@id";
        public static string cmdDeleteTermek = "DELETE FROM sportuzlet.termekek WHERE id=@id";

        public static string cmdInsertSzemely = "INSERT INTO sportuzlet.szemely (nev, cim) VALUES (@nev, @cim)";
        public static string cmdInsertTermek = "INSERT INTO sportuzlet.termekek (termekNev, egysegar) VALUES (@termekNev, @egysegar)";
    }
}
