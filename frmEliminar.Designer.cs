namespace ExamenADONET
{
    partial class frmEliminar
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
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            txtFechaCreacion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            btnListar = new Button();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(txtFechaCreacion);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 177);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(214, 66);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(209, 94);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            // txtID
            // 
            txtID.BackColor = SystemColors.GradientActiveCaption;
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtID.Location = new Point(12, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(147, 27);
            txtID.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 9;
            label1.Text = "Ingresar ID";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(320, 27);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(125, 29);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(165, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(147, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 256);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(433, 250);
            dgvProductos.TabIndex = 6;
            // 
            // frmEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 521);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnListar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvProductos);
            Name = "frmEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Producto";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEliminar;
        private TextBox txtFechaCreacion;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btnListar;
        private Button btnBuscar;
        private DataGridView dgvProductos;
    }
}