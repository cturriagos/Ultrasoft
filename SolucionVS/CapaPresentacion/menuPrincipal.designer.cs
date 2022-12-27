namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlarea = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMetricas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlarea
            // 
            this.pnlarea.BackColor = System.Drawing.SystemColors.Control;
            this.pnlarea.Location = new System.Drawing.Point(17, 263);
            this.pnlarea.Margin = new System.Windows.Forms.Padding(8);
            this.pnlarea.Name = "pnlarea";
            this.pnlarea.Size = new System.Drawing.Size(3601, 1628);
            this.pnlarea.TabIndex = 3;
            this.pnlarea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlarea_MouseMove);
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrar.Location = new System.Drawing.Point(3538, 13);
            this.cerrar.Margin = new System.Windows.Forms.Padding(8);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 75);
            this.cerrar.TabIndex = 1;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(3447, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 83);
            this.button4.TabIndex = 2;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Image = global::CapaPresentacion.Properties.Resources.Home_35px;
            this.btnInicio.Location = new System.Drawing.Point(7, 6);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(8);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(156, 111);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInicio_MouseMove);
            // 
            // btnMetricas
            // 
            this.btnMetricas.BackColor = System.Drawing.Color.Transparent;
            this.btnMetricas.FlatAppearance.BorderSize = 0;
            this.btnMetricas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMetricas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetricas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMetricas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetricas.Location = new System.Drawing.Point(1625, 7);
            this.btnMetricas.Margin = new System.Windows.Forms.Padding(8);
            this.btnMetricas.Name = "btnMetricas";
            this.btnMetricas.Size = new System.Drawing.Size(600, 111);
            this.btnMetricas.TabIndex = 3;
            this.btnMetricas.Text = "Metricas";
            this.btnMetricas.UseVisualStyleBackColor = false;
            this.btnMetricas.Click += new System.EventHandler(this.btnRegistro_Click_1);
            this.btnMetricas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistro_MouseMove);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(2318, 6);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(8);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(600, 111);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.Location = new System.Drawing.Point(246, 5);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(8);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(600, 111);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnActividad_Click);
            this.btnProductos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnActividad_MouseMove);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.Location = new System.Drawing.Point(935, 6);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(8);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(600, 111);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.Transparent;
            this.Ventas.FlatAppearance.BorderSize = 0;
            this.Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ventas.Location = new System.Drawing.Point(2996, 7);
            this.Ventas.Margin = new System.Windows.Forms.Padding(8);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(600, 111);
            this.Ventas.TabIndex = 12;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = false;
            this.Ventas.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.DarkGray;
            this.pnlContenedor.Controls.Add(this.Ventas);
            this.pnlContenedor.Controls.Add(this.btnClientes);
            this.pnlContenedor.Controls.Add(this.btnProductos);
            this.pnlContenedor.Controls.Add(this.btnEmpleados);
            this.pnlContenedor.Controls.Add(this.btnMetricas);
            this.pnlContenedor.Controls.Add(this.btnInicio);
            this.pnlContenedor.Location = new System.Drawing.Point(17, 97);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(8);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(3604, 124);
            this.pnlContenedor.TabIndex = 6;
            this.pnlContenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlContenedor_MouseMove);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(3638, 1916);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseMove);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlarea;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMetricas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button Ventas;
        internal System.Windows.Forms.Panel pnlContenedor;
    }
}

