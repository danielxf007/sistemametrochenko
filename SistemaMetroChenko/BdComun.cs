using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaMetroChenko
{
    class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=db4free.net; database=santiagootalvaro; Uid=formoldog; pwd=seattle3317; old guids=true");

            conectar.Open();
            return conectar;
        }
    }
}
