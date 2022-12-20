namespace CapaPresentacion
{
    partial class menuInicio
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
            this.components = new System.ComponentModel.Container();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlInicio.BackgroundImage = global::CapaPresentacion.Properties.Resources.logo1;
            this.pnlInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInicio.Controls.Add(this.lblFecha);
            this.pnlInicio.Controls.Add(this.lblHora);
            this.pnlInicio.Location = new System.Drawing.Point(-2, 0);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1271, 585);
            this.pnlInicio.TabIndex = 5;
            this.pnlInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInicio_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(552, 239);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(707, 91);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Blue;
            this.lblHora.Location = new System.Drawing.Point(558, 45);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(594, 207);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // menuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 585);
            this.Controls.Add(this.pnlInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "menuInicio";
            this.pnlInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}