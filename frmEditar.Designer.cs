namespace ExamenADONET
{
    partial class frmEditar
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
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            btnListar = new Button();
            label1 = new Label();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            txtFechaCreacion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 261);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(433, 250);
            dgvProductos.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(165, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(147, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(320, 32);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(125, 29);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresar ID";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.GradientActiveCaption;
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtID.Location = new Point(12, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(147, 27);
            txtID.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtFechaCreacion);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 177);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Producto";
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.Location = new Point(79, 133);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.Size = new Size(129, 27);
            txtFechaCreacion.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(79, 99);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(129, 27);
            txtStock.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 66);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(129, 27);
            txtPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 27);
            txtNombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 136);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 102);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 69);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 36);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Crimson;
            btnGuardar.Location = new Point(235, 69);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(188, 91);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 523);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnListar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvProductos);
            Name = "frmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Productos";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnBuscar;
        private Button btnListar;
        private Label label1;
        private TextBox txtID;
        private GroupBox groupBox1;
        private TextBox txtFechaCreacion;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
    }
}