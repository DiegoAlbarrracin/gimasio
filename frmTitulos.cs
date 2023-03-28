using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_1
{
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {//titulos
            Form frmABMTitulo = new frmABMTitulo();
            frmABMTitulo.Show();
        }
    }
}
