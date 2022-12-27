
namespace CapaPresentacion
{
    partial class frmMetrica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetrica));
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMetricas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSimbolo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lbSimboloMetrica = new System.Windows.Forms.Label();
            this.lbNombreMetrica = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetricas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(-16, -103);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(155, 36);
            this.lblEmpleados.TabIndex = 10;
            this.lblEmpleados.Text = "Empleados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMetricas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(761, 287);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // dgvMetricas
            // 
            this.dgvMetricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetricas.Location = new System.Drawing.Point(8, 40);
            this.dgvMetricas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMetricas.Name = "dgvMetricas";
            this.dgvMetricas.RowHeadersWidth = 51;
            this.dgvMetricas.Size = new System.Drawing.Size(740, 233);
            this.dgvMetricas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCodigo);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Controls.Add(this.txbSimbolo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.lbSimboloMetrica);
            this.groupBox1.Controls.Add(this.lbNombreMetrica);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(863, 274);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbSimbolo
            // 
            this.txbSimbolo.Location = new System.Drawing.Point(368, 64);
            this.txbSimbolo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSimbolo.Name = "txbSimbolo";
            this.txbSimbolo.Size = new System.Drawing.Size(61, 29);
            this.txbSimbolo.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(739, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 41);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(134, 213);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 41);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(16, 213);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 41);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(158, 64);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(195, 29);
            this.txbDescripcion.TabIndex = 3;
            // 
            // lbSimboloMetrica
            // 
            this.lbSimboloMetrica.AutoSize = true;
            this.lbSimboloMetrica.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimboloMetrica.Location = new System.Drawing.Point(364, 38);
            this.lbSimboloMetrica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSimboloMetrica.Name = "lbSimboloMetrica";
            this.lbSimboloMetrica.Size = new System.Drawing.Size(65, 19);
            this.lbSimboloMetrica.TabIndex = 2;
            this.lbSimboloMetrica.Text = "Simbolo";
            // 
            // lbNombreMetrica
            // 
            this.lbNombreMetrica.AutoSize = true;
            this.lbNombreMetrica.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreMetrica.Location = new System.Drawing.Point(154, 38);
            this.lbNombreMetrica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreMetrica.Name = "lbNombreMetrica";
            this.lbNombreMetrica.Size = new System.Drawing.Size(90, 19);
            this.lbNombreMetrica.TabIndex = 0;
            this.lbNombreMetrica.Text = "Descripción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, -118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(16, 64);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.ReadOnly = true;
            this.txbCodigo.Size = new System.Drawing.Size(134, 29);
            this.txbCodigo.TabIndex = 22;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(12, 38);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(59, 19);
            this.lbCodigo.TabIndex = 21;
            this.lbCodigo.Text = "Codigo";
            // 
            // frmMetrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMetrica";
            this.Text = "frmMetrica";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetricas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMetricas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSimbolo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lbSimboloMetrica;
        private System.Windows.Forms.Label lbNombreMetrica;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lbCodigo;
    }
}