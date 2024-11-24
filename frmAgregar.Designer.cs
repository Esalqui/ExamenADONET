namespace ExamenADONET
{
    partial class frmAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtFechaCreacion = new TextBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnListar = new Button();
            dgvProductos = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(221, 61);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(101, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(328, 61);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(101, 27);
            txtStock.TabIndex = 2;
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.Location = new Point(435, 61);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.Size = new Size(122, 27);
            txtFechaCreacion.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(12, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(160, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre del Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(221, 38);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(328, 38);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 20);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(435, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 7;
            label1.Text = "Fecha Creación";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(563, 59);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(663, 59);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 94);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(745, 344);
            dgvProductos.TabIndex = 10;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.Highlight;
            lblTitulo.Location = new Point(263, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 28);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "AGREGAR PRODUCTOS";
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(btnListar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(txtFechaCreacion);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Productos";
            TopMost = true;
            Load += frmAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtFechaCreacion;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Label label1;
        private Button btnAgregar;
        private Button btnListar;
        private DataGridView dgvProductos;
        private Label lblTitulo;
    }
}