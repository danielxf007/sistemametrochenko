using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaMetroChenko
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Usuario pCliente = new Usuario();
            pCliente.uid = txt_uid.Text.Trim();
            pCliente.nombre = txt_nombre.Text.Trim();
            pCliente.documento = txt_documento.Text.Trim();
            pCliente.saldo = 0;
            pCliente.fechaRegistro = DateTime.Now.ToString("dd-MM-yyyy");

            int resultado = UsuariosDAL.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void ButtonArduino_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            string entrada = serialPort1.ReadLine();
            serialPort1.Close();
            txt_uid.Text = entrada;
        }
    }
}
