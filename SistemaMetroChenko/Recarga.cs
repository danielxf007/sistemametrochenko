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
    public partial class Recarga : Form
    {
        public Recarga()
        {
            InitializeComponent();
        }

        private void Recarga_Load(object sender, EventArgs e)
        {
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
