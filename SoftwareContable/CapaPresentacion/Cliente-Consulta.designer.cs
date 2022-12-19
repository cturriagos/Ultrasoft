namespace CapaPresentacion
{
    partial class Cliente_Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgBusqueda = new System.Windows.Forms.DataGridView();
            this.btnverConsulta = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtNombreClienteConsulta = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(13, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 408);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtgBusqueda
            // 
            this.dtgBusqueda.AllowUserToAddRows = false;
            this.dtgBusqueda.AllowUserToDeleteRows = false;
            this.dtgBusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBusqueda.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgBusqueda.EnableHeadersVisualStyles = false;
            this.dtgBusqueda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgBusqueda.Location = new System.Drawing.Point(44, 156);
            this.dtgBusqueda.Name = "dtgBusqueda";
            this.dtgBusqueda.ReadOnly = true;
            this.dtgBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgBusqueda.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dtgBusqueda.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgBusqueda.Size = new System.Drawing.Size(734, 191);
            this.dtgBusqueda.TabIndex = 184;
            // 
            // btnverConsulta
            // 
            this.btnverConsulta.BackColor = System.Drawing.Color.Blue;
            this.btnverConsulta.FlatAppearance.BorderSize = 0;
            this.btnverConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnverConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverConsulta.ForeColor = System.Drawing.Color.White;
            this.btnverConsulta.Image = global::CapaPresentacion.Properties.Resources.clientes;
            this.btnverConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnverConsulta.Location = new System.Drawing.Point(337, 369);
            this.btnverConsulta.Name = "btnverConsulta";
            this.btnverConsulta.Size = new System.Drawing.Size(148, 47);
            this.btnverConsulta.TabIndex = 183;
            this.btnverConsulta.Text = "      Buscar";
            this.btnverConsulta.UseVisualStyleBackColor = false;
            this.btnverConsulta.Click += new System.EventHandler(this.btnverConsulta_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.Blue;
            this.lblConsulta.Location = new System.Drawing.Point(322, 51);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(174, 42);
            this.lblConsulta.TabIndex = 182;
            this.lblConsulta.Text = "CLIENTE";
            this.lblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreClienteConsulta
            // 
            this.txtNombreClienteConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteConsulta.Location = new System.Drawing.Point(372, 108);
            this.txtNombreClienteConsulta.Name = "txtNombreClienteConsulta";
            this.txtNombreClienteConsulta.Size = new System.Drawing.Size(263, 26);
            this.txtNombreClienteConsulta.TabIndex = 181;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Gray;
            this.lblCodigo.Location = new System.Drawing.Point(144, 104);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(222, 30);
            this.lblCodigo.TabIndex = 180;
            this.lblCodigo.Text = "Codigo del Cliente:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.button4.Location = new System.Drawing.Point(750, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 32);
            this.button4.TabIndex = 188;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.cerrar.Location = new System.Drawing.Point(788, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 32);
            this.cerrar.TabIndex = 187;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Cliente_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(822, 458);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.dtgBusqueda);
            this.Controls.Add(this.btnverConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.txtNombreClienteConsulta);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_Consulta";
            this.Text = "Nombre";
            this.Load += new System.EventHandler(this.Cliente_Consulta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cliente_Consulta_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgBusqueda;
        private System.Windows.Forms.Button btnverConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtNombreClienteConsulta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cerrar;
    }
}