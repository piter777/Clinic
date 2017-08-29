namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.odbcDataSet = new WindowsFormsApplication3.odbcDataSet();
            this.likBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.likTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // odbcDataSet
            // 
            this.odbcDataSet.DataSetName = "odbcDataSet";
            this.odbcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // likBindingSource
            // 
            this.likBindingSource.DataMember = "lik";
            this.likBindingSource.DataSource = this.odbcDataSet;
            // 
            // likTableAdapter
            // 
            this.likTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource likBindingSource;
        private odbcDataSet odbcDataSet;
        private odbcDataSetTableAdapters.likTableAdapter likTableAdapter;
    }
}