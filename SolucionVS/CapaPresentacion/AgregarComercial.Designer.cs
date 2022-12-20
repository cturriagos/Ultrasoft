namespace CapaPresentacion
{
    partial class AgregarComercial
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(-1, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 450);
            this.panel4.TabIndex = 142;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(-1, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 16);
            this.panel3.TabIndex = 141;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(416, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 450);
            this.panel2.TabIndex = 140;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 39);
            this.panel1.TabIndex = 139;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.ForeColor = System.Drawing.Color.Black;
            this.txtDireccionCliente.Location = new System.Drawing.Point(55, 107);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(320, 20);
            this.txtDireccionCliente.TabIndex = 143;
            this.txtDireccionCliente.Text = "Dirección";
            this.txtDireccionCliente.Enter += new System.EventHandler(this.txtDireccionCliente_Enter);
            this.txtDireccionCliente.Leave += new System.EventHandler(this.txtDireccionCliente_Leave);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCliente.Location = new System.Drawing.Point(55, 148);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(320, 20);
            this.txtNombreCliente.TabIndex = 144;
            this.txtNombreCliente.Text = "Nombre";
            this.txtNombreCliente.Enter += new System.EventHandler(this.txtNombreCliente_Enter);
            this.txtNombreCliente.Leave += new System.EventHandler(this.txtNombreCliente_Leave);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.txtEmailCliente.Location = new System.Drawing.Point(55, 187);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(320, 20);
            this.txtEmailCliente.TabIndex = 145;
            this.txtEmailCliente.Text = "E-mail";
            this.txtEmailCliente.Enter += new System.EventHandler(this.txtEmailCliente_Enter);
            this.txtEmailCliente.Leave += new System.EventHandler(this.txtEmailCliente_Leave);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(55, 224);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(320, 20);
            this.txtTelefonoCliente.TabIndex = 146;
            this.txtTelefonoCliente.Text = "Teléfono";
            this.txtTelefonoCliente.Enter += new System.EventHandler(this.txtTelefonoCliente_Enter);
            this.txtTelefonoCliente.Leave += new System.EventHandler(this.txtTelefonoCliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "DNI Propietario:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 147;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 55;
            this.lineShape8.X2 = 375;
            this.lineShape8.Y1 = 127;
            this.lineShape8.Y2 = 127;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.lineShape8});
            this.shapeContainer1.Size = new System.Drawing.Size(431, 416);
            this.shapeContainer1.TabIndex = 149;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 55;
            this.lineShape3.X2 = 375;
            this.lineShape3.Y1 = 245;
            this.lineShape3.Y2 = 245;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 55;
            this.lineShape2.X2 = 375;
            this.lineShape2.Y1 = 207;
            this.lineShape2.Y2 = 207;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 55;
            this.lineShape1.X2 = 375;
            this.lineShape1.Y1 = 168;
            this.lineShape1.Y2 = 168;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Blue;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoCliente.Image = global::CapaPresentacion.Properties.Resources.Add_New_35px;
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(239, 339);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(120, 37);
            this.btnNuevoCliente.TabIndex = 138;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.Blue;
            this.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCliente.Image = global::CapaPresentacion.Properties.Resources.Checkmark_35px;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(77, 339);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(124, 37);
            this.btnRegistrarCliente.TabIndex = 137;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Blue;
            this.lblCliente.Location = new System.Drawing.Point(128, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(174, 42);
            this.lblCliente.TabIndex = 150;
            this.lblCliente.Text = "COMERCIAL";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button4.Location = new System.Drawing.Point(361, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 32);
            this.button4.TabIndex = 169;
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
            this.cerrar.Location = new System.Drawing.Point(397, 1);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 32);
            this.cerrar.TabIndex = 168;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // AgregarComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(431, 416);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarComercial";
            this.Text = "AgregarComercial";
            this.Load += new System.EventHandler(this.AgregarComercial_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cerrar;
    }
}