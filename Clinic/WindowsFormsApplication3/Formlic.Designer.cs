namespace WindowsFormsApplication3
{
    partial class Formlic
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odbcDataSet = new WindowsFormsApplication3.odbcDataSet();
            this.pacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.docTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.docTableAdapter();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.pacTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.pacTableAdapter();
            this.likTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.likTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mysqlDataSet = new WindowsFormsApplication3.mysqlDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // docBindingSource
            // 
            this.docBindingSource.DataMember = "doc";
            this.docBindingSource.DataSource = this.odbcDataSet;
            // 
            // odbcDataSet
            // 
            this.odbcDataSet.DataSetName = "odbcDataSet";
            this.odbcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacBindingSource
            // 
            this.pacBindingSource.DataMember = "pac";
            this.pacBindingSource.DataSource = this.odbcDataSet;
            // 
            // likBindingSource
            // 
            this.likBindingSource.DataMember = "lik";
            this.likBindingSource.DataSource = this.odbcDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.docBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(681, 287);
            this.reportViewer1.TabIndex = 0;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(201, 305);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 10;
            this.button17.Text = "По карткам";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(112, 305);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 23);
            this.button16.TabIndex = 9;
            this.button16.Text = "По паціентам";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 305);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 23);
            this.button15.TabIndex = 8;
            this.button15.Text = "По кабінетам";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // pacTableAdapter
            // 
            this.pacTableAdapter.ClearBeforeFill = true;
            // 
            // likTableAdapter
            // 
            this.likTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "По докторам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pacBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(681, 287);
            this.reportViewer2.TabIndex = 11;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.likBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report10.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(12, 12);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(681, 287);
            this.reportViewer3.TabIndex = 12;
            this.reportViewer3.Visible = false;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.docBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report3.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(12, 12);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(681, 287);
            this.reportViewer4.TabIndex = 13;
            this.reportViewer4.Visible = false;
            // 
            // mysqlDataSet
            // 
            this.mysqlDataSet.DataSetName = "mysqlDataSet";
            this.mysqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Formlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formlic";
            this.Text = "Отчети";
            this.Load += new System.EventHandler(this.Formlic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource docBindingSource;
        private odbcDataSet odbcDataSet;
        private odbcDataSetTableAdapters.docTableAdapter docTableAdapter;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.BindingSource pacBindingSource;
        private odbcDataSetTableAdapters.pacTableAdapter pacTableAdapter;
        private System.Windows.Forms.BindingSource likBindingSource;
        private odbcDataSetTableAdapters.likTableAdapter likTableAdapter;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private mysqlDataSet mysqlDataSet;
    }
}