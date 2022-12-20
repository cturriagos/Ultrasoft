namespace CapaPresentacion
{
    partial class Reporte_Trabajador
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new CapaPresentacion.DataSet1();
            this.TrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrabajadoresTableAdapter = new CapaPresentacion.DataSet1TableAdapters.TrabajadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrabajadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TrabajadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(815, 624);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TrabajadoresBindingSource
            // 
            this.TrabajadoresBindingSource.DataMember = "Trabajadores";
            this.TrabajadoresBindingSource.DataSource = this.DataSet1;
            // 
            // TrabajadoresTableAdapter
            // 
            this.TrabajadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Trabajador";
            this.Text = "Reporte_Trabajador";
            this.Load += new System.EventHandler(this.Reporte_Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrabajadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrabajadoresBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.TrabajadoresTableAdapter TrabajadoresTableAdapter;
    }
}