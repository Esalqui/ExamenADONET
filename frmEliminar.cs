using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONET
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int Id = Convert.ToInt32(txtID.Text);
            producto = DAO.DatosProducto.ObtenerProducto(Id);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString();
                txtStock.Text = producto.Stock.ToString();
                txtFechaCreacion.Text = producto.FechaCreacion.ToString();
            }
            else
            {
                MessageBox.Show("Producto No encontrado");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DAO.DatosProducto.ListarProductos("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text);
            int Respuesta = DatosProducto.EliminarProductos(Id);
            if (Respuesta == 1)
            {
                MessageBox.Show("El producto se eliminó correctamente.");
                txtID.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtFechaCreacion.Text = "";

                
            }
            else
            {
                MessageBox.Show("El producto indicado NO Existe");
            }
        }
    }
}
