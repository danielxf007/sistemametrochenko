using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMetroChenko
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            if (registro.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void ButtonRecharge_Click(object sender, EventArgs e)
        {
            Recarga recarga = new Recarga();
            recarga.ShowDialog();
            if (recarga.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void ButtonDB_Click(object sender, EventArgs e)
        {
            try
            {
                BdComun.ObtenerConexion();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
