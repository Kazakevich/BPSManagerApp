namespace BPSBank.Admin
{
    partial class Отчет_по_заказам
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
            this.bPSDBDataSet = new BPSBank.BPSDBDataSet();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new BPSBank.BPSDBDataSetTableAdapters.View_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BPSBank.Admin.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(607, 274);
            this.reportViewer1.TabIndex = 0;
            // 
            // bPSDBDataSet
            // 
            this.bPSDBDataSet.DataSetName = "BPSDBDataSet";
            this.bPSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.bPSDBDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_по_заказам
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 274);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_по_заказам";
            this.Text = "Отчет_по_заказам";
            this.Load += new System.EventHandler(this.Отчет_по_заказам_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BPSDBDataSet bPSDBDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private BPSDBDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
    }
}