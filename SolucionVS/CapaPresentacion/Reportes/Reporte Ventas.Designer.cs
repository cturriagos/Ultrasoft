namespace CapaPresentacion
{
    partial class Reporte_Ventas
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
            this.DataSet4 = new CapaPresentacion.DataSet4();
            this.ReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVentaTableAdapter = new CapaPresentacion.DataSet4TableAdapters.ReporteVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 88;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(820, 628);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteVentaBindingSource
            // 
            this.ReporteVentaBindingSource.DataMember = "ReporteVenta";
            this.ReporteVentaBindingSource.DataSource = this.DataSet4;
            // 
            // ReporteVentaTableAdapter
            // 
            this.ReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 626);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Ventas";
            this.Text = "Reporte_Ventas";
            this.Load += new System.EventHandler(this.Reporte_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteVentaBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.ReporteVentaTableAdapter ReporteVentaTableAdapter;

    }
}