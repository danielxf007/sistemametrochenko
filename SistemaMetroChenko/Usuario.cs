using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetroChenko
{
    class Usuario
    {
        public int iddatos { get; set; }
        public string uid { get; set; }
        public string nombre { get; set; }
        public string documento { get; set; }
        public int saldo { get; set; }
        public string fechaRegistro { get; set; }

        public Usuario() { }

        public Usuario(int piddatos,string puid, string pnombre, string pdocumento, int psaldo, string pfechaRegistro)

        {
            this.iddatos = piddatos;
            this.uid = puid;
            this.nombre = pnombre;
            this.documento = pdocumento;
            this.saldo = psaldo;
            this.fechaRegistro = pfechaRegistro;
        }

    }
}
