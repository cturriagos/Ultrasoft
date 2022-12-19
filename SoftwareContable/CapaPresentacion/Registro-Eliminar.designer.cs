namespace CapaPresentacion
{
    partial class Registro_Eliminar
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
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbElegirRegistro = new System.Windows.Forms.ComboBox();
            this.dgvResgistroEliminar = new System.Windows.Forms.DataGridView();
            this.btnNuevoRegistroEliminar = new System.Windows.Forms.Button();
            this.btnRegistroEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResgistroEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajador.ForeColor = System.Drawing.Color.Blue;
            this.lblTrabajador.Location = new System.Drawing.Point(486, 13);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(174, 42);
            this.lblTrabajador.TabIndex = 75;
            this.lblTrabajador.Text = "REGISTRO";
            this.lblTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbElegirRegistro
            // 
            this.cmbElegirRegistro.BackColor = System.Drawing.Color.Blue;
            this.cmbElegirRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbElegirRegistro.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbElegirRegistro.FormattingEnabled = true;
            this.cmbElegirRegistro.Items.AddRange(new object[] {
            "Bodega",
            "Compra",
            "Venta"});
            this.cmbElegirRegistro.Location = new System.Drawing.Point(51, 106);
            this.cmbElegirRegistro.Name = "cmbElegirRegistro";
            this.cmbElegirRegistro.Size = new System.Drawing.Size(214, 28);
            this.cmbElegirRegistro.TabIndex = 76;
            this.cmbElegirRegistro.Text = "Elegir Registro";
            // 
            // dgvResgistroEliminar
            // 
            this.dgvResgistroEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResgistroEliminar.Location = new System.Drawing.Point(283, 72);
            this.dgvResgistroEliminar.Name = "dgvResgistroEliminar";
            this.dgvResgistroEliminar.Size = new System.Drawing.Size(550, 338);
            this.dgvResgistroEliminar.TabIndex = 77;
            // 
            // btnNuevoRegistroEliminar
            // 
            this.btnNuevoRegistroEliminar.BackColor = System.Drawing.Color.Blue;
            this.btnNuevoRegistroEliminar.FlatAppearance.BorderSize = 0;
            this.btnNuevoRegistroEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnNuevoRegistroEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRegistroEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistroEliminar.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistroEliminar.Image = global::CapaPresentacion.Properties.Resources.Add_New_35px1;
            this.btnNuevoRegistroEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistroEliminar.Location = new System.Drawing.Point(62, 297);
            this.btnNuevoRegistroEliminar.Name = "btnNuevoRegistroEliminar";
            this.btnNuevoRegistroEliminar.Size = new System.Drawing.Size(128, 52);
            this.btnNuevoRegistroEliminar.TabIndex = 81;
            this.btnNuevoRegistroEliminar.Text = "Nuevo";
            this.btnNuevoRegistroEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistroEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegistroEliminar
            // 
            this.btnRegistroEliminar.BackColor = System.Drawing.Color.Blue;
            this.btnRegistroEliminar.FlatAppearance.BorderSize = 0;
            this.btnRegistroEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnRegistroEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistroEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroEliminar.ForeColor = System.Drawing.Color.White;
            this.btnRegistroEliminar.Image = global::CapaPresentacion.Properties.Resources.Trash_35px;
            this.btnRegistroEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEliminar.Location = new System.Drawing.Point(62, 220);
            this.btnRegistroEliminar.Name = "btnRegistroEliminar";
            this.btnRegistroEliminar.Size = new System.Drawing.Size(128, 52);
            this.btnRegistroEliminar.TabIndex = 80;
            this.btnRegistroEliminar.Text = "Eliminar";
            this.btnRegistroEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroEliminar.UseVisualStyleBackColor = false;
            this.btnRegistroEliminar.Click += new System.EventHandler(this.btnRegistroEliminar_Click);
            // 
            // Registro_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(865, 430);
            this.Controls.Add(this.btnNuevoRegistroEliminar);
            this.Controls.Add(this.btnRegistroEliminar);
            this.Controls.Add(this.dgvResgistroEliminar);
            this.Controls.Add(this.cmbElegirRegistro);
            this.Controls.Add(this.lblTrabajador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Eliminar";
            this.Text = "Registro_Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResgistroEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.ComboBox cmbElegirRegistro;
        private System.Windows.Forms.DataGridView dgvResgistroEliminar;
        private System.Windows.Forms.Button btnRegistroEliminar;
        private System.Windows.Forms.Button btnNuevoRegistroEliminar;
    }
}