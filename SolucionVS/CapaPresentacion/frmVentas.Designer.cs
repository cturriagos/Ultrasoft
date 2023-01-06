namespace CapaPresentacion
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.BtnVerificaCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDatosCliente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.BtnCobrar = new System.Windows.Forms.Button();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtMetrica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(626, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(198, 33);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(0, 18);
            this.lblNumFactura.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(921, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI de Cliente :";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.Location = new System.Drawing.Point(161, 76);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(235, 27);
            this.txtDniCliente.TabIndex = 6;
            // 
            // BtnVerificaCliente
            // 
            this.BtnVerificaCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificaCliente.Location = new System.Drawing.Point(412, 77);
            this.BtnVerificaCliente.Name = "BtnVerificaCliente";
            this.BtnVerificaCliente.Size = new System.Drawing.Size(84, 26);
            this.BtnVerificaCliente.TabIndex = 7;
            this.BtnVerificaCliente.Text = "Verificar";
            this.BtnVerificaCliente.UseVisualStyleBackColor = true;
            this.BtnVerificaCliente.Click += new System.EventHandler(this.BtnVerificaCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Datos del Cliente";
            // 
            // dgvDatosCliente
            // 
            this.dgvDatosCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCliente.Location = new System.Drawing.Point(30, 135);
            this.dgvDatosCliente.Name = "dgvDatosCliente";
            this.dgvDatosCliente.ReadOnly = true;
            this.dgvDatosCliente.RowHeadersVisible = false;
            this.dgvDatosCliente.Size = new System.Drawing.Size(1200, 95);
            this.dgvDatosCliente.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Producto :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(893, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vendedor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Precio :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cantidad :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(125, 342);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(94, 27);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Text = "0,00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(125, 389);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(94, 27);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Métrica :";
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Items.AddRange(new object[] {
            "Café",
            "Arroz",
            "Cacao"});
            this.cbxProducto.Location = new System.Drawing.Point(125, 296);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(211, 28);
            this.cbxProducto.TabIndex = 21;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.CbxProducto_SelectedIndexChanged);
            // 
            // dgvDetalleVenta
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre_Producto,
            this.Cantidad,
            this.Metrica,
            this.Precio_Unitario,
            this.SubTotal});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(376, 265);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(854, 210);
            this.dgvDetalleVenta.TabIndex = 22;
            // 
            // Id_Producto
            // 
            this.Id_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_Producto.HeaderText = "Código ";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Producto.HeaderText = "Nombre Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Metrica
            // 
            this.Metrica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Metrica.HeaderText = "Métrica";
            this.Metrica.Name = "Metrica";
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio_Unitario.HeaderText = "Precio";
            this.Precio_Unitario.Name = "Precio_Unitario";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(762, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Detalle de Venta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(822, 490);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(825, 520);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 24);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCobrar.Location = new System.Drawing.Point(1052, 502);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(178, 42);
            this.BtnCobrar.TabIndex = 30;
            this.BtnCobrar.Text = "Cobrar";
            this.BtnCobrar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(103, 479);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(168, 40);
            this.BtnRegistrarProducto.TabIndex = 32;
            this.BtnRegistrarProducto.Text = "Registrar";
            this.BtnRegistrarProducto.UseVisualStyleBackColor = true;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.CustomFormat = "";
            this.dtpFechaVenta.Location = new System.Drawing.Point(1002, 33);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(228, 20);
            this.dtpFechaVenta.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(998, 520);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 24);
            this.label18.TabIndex = 36;
            this.label18.Text = "$";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(1001, 76);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(229, 27);
            this.txtVendedor.TabIndex = 37;
            this.txtVendedor.Text = "Administrador";
            // 
            // txtMetrica
            // 
            this.txtMetrica.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetrica.Location = new System.Drawing.Point(125, 435);
            this.txtMetrica.Name = "txtMetrica";
            this.txtMetrica.ReadOnly = true;
            this.txtMetrica.Size = new System.Drawing.Size(121, 27);
            this.txtMetrica.TabIndex = 38;
            this.txtMetrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(73, 27);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetrica);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.BtnRegistrarProducto);
            this.Controls.Add(this.BtnCobrar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDatosCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnVerificaCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button BtnVerificaCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDatosCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button BtnCobrar;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtMetrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}