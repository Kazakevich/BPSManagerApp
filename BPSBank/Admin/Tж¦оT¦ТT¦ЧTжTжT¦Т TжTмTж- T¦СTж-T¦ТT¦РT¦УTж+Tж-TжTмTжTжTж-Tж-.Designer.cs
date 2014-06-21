namespace BPSBank
{
    partial class Отчет_по_сотрудникам
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
            this.BPSDBDataSet = new BPSBank.BPSDBDataSet();
            this.PersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonnelTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.PersonnelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BPSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonnelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BPSBank.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(898, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // BPSDBDataSet
            // 
            this.BPSDBDataSet.DataSetName = "BPSDBDataSet";
            this.BPSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonnelBindingSource
            // 
            this.PersonnelBindingSource.DataMember = "Personnel";
            this.PersonnelBindingSource.DataSource = this.BPSDBDataSet;
            // 
            // PersonnelTableAdapter
            // 
            this.PersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_по_сотрудникам
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 282);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_по_сотрудникам";
            this.Text = "Отчет_по_сотрудникам";
            this.Load += new System.EventHandler(this.Отчет_по_сотрудникам_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BPSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonnelBindingSource;
        private BPSDBDataSet BPSDBDataSet;
        private BPSDBDataSetTableAdapters.PersonnelTableAdapter PersonnelTableAdapter;
    }
}