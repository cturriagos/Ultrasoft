namespace CapaPresentacion
{
    partial class ComprobanteVenta
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
            this.venta = new CapaPresentacion.venta();
            this.factura_VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_VentaTableAdapter = new CapaPresentacion.ventaTableAdapters.factura_VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_VentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.factura_VentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.REPORTEFACTURAVENTA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(789, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // venta
            // 
            this.venta.DataSetName = "venta";
            this.venta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factura_VentaBindingSource
            // 
            this.factura_VentaBindingSource.DataMember = "factura_Venta";
            this.factura_VentaBindingSource.DataSource = this.venta;
            // 
            // factura_VentaTableAdapter
            // 
            this.factura_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // ComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ComprobanteVenta";
            this.Text = "VENTA";
            this.Load += new System.EventHandler(this.ComprobanteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_VentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource factura_VentaBindingSource;
        private venta venta;
        private ventaTableAdapters.factura_VentaTableAdapter factura_VentaTableAdapter;
    }
}