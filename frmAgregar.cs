using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace ExamenADONET
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DAO.DatosProducto.ListarProductos("");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            decimal Precio = Convert.ToDecimal(txtPrecio.Text);
            int Stock = Convert.ToInt32(txtPrecio.Text);
            DateTime FechaCreacion = Convert.ToDateTime(txtFechaCreacion.Text);
            int Respuesta = DatosProducto.CrearProductos(Nombre, Precio, Stock, FechaCreacion);
            if (Respuesta == 1)
            {
                MessageBox.Show("El producto se registró correctamente.");
            }
            else
            {
                MessageBox.Show("Error al insertar el producto. Comuníquese con el administrador del sistema.");
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
