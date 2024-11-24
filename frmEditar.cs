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
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = DAO.DatosProducto.ListarProductos("");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text);
            string Nombre = txtNombre.Text;
            decimal Precio = Convert.ToDecimal(txtPrecio.Text);
            int Stock = Convert.ToInt32(txtStock.Text);
            DateTime FechaCreacion = Convert.ToDateTime(txtFechaCreacion.Text);
            int Respuesta = DatosProducto.ModificarProductos(Id, Nombre, Precio, Stock, FechaCreacion);
            if (Respuesta == 1)
            {
                MessageBox.Show("El producto se modificó correctamente.");
            }
            else
            {
                MessageBox.Show("Error al insertar el producto. Comuníquese con el administrador del sistema.");
            }
        }
    }
    
}
