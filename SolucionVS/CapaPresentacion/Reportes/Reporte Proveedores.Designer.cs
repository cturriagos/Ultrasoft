namespace CapaPresentacion
{
    partial class Reporte_Proveedores
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
            this.DataSet2 = new CapaPresentacion.DataSet2();
            this.ProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedoresTableAdapter = new CapaPresentacion.DataSet2TableAdapters.ProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(818, 625);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProveedoresBindingSource
            // 
            this.ProveedoresBindingSource.DataMember = "Proveedores";
            this.ProveedoresBindingSource.DataSource = this.DataSet2;
            // 
            // ProveedoresTableAdapter
            // 
            this.ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Proveedores";
            this.Text = "Reporte_Proveedores";
            this.Load += new System.EventHandler(this.Reporte_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProveedoresBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.ProveedoresTableAdapter ProveedoresTableAdapter;
    }
}