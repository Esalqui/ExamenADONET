using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ExamenADONET
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar FrmBuscar = new frmBuscar();
            FrmBuscar.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar FrmAgregar = new frmAgregar();
            FrmAgregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmEditar FrmEditar = new frmEditar();
            FrmEditar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar FrmEliminar = new frmEliminar();
            FrmEliminar.ShowDialog();
        }
    }
}
