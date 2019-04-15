using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaMetroChenko
{
    class UsuariosDAL
    {
        public static int Agregar(Usuario pCliente)
        {

            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into datos (uid, nombre, documento, saldo, fechaRegistro) values ('{0}','{1}','{2}', '{3}', '{4}')",
                pCliente.uid, pCliente.nombre, pCliente.documento, pCliente.saldo, pCliente.fechaRegistro), BdComun.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;

        }
    }
}
