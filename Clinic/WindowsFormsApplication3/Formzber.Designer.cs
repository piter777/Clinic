namespace WindowsFormsApplication3
{
    partial class Formzber
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
            this.posBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odbcDataSet = new WindowsFormsApplication3.odbcDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.adrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adrTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.adrTableAdapter();
            this.posTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.posTableAdapter();
            this.posBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mysqlDataSet = new WindowsFormsApplication3.mysqlDataSet();
            this.posTableAdapter1 = new WindowsFormsApplication3.mysqlDataSetTableAdapters.posTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.posBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // posBindingSource
            // 
            this.posBindingSource.DataMember = "pos";
            this.posBindingSource.DataSource = this.odbcDataSet;
            // 
            // odbcDataSet
            // 
            this.odbcDataSet.DataSetName = "odbcDataSet";
            this.odbcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Конвертація в аксес";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(754, 180);
            this.dataGridView2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 20);
            this.button3.TabIndex = 5;
            this.button3.Text = "Збережна процедура";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adrBindingSource
            // 
            this.adrBindingSource.DataMember = "adr";
            this.adrBindingSource.DataSource = this.odbcDataSet;
            // 
            // adrTableAdapter
            // 
            this.adrTableAdapter.ClearBeforeFill = true;
            // 
            // posTableAdapter
            // 
            this.posTableAdapter.ClearBeforeFill = true;
            // 
            // posBindingSource1
            // 
            this.posBindingSource1.DataMember = "pos";
            this.posBindingSource1.DataSource = this.mysqlDataSet;
            // 
            // mysqlDataSet
            // 
            this.mysqlDataSet.DataSetName = "mysqlDataSet";
            this.mysqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posTableAdapter1
            // 
            this.posTableAdapter1.ClearBeforeFill = true;
            // 
            // Formzber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 232);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Name = "Formzber";
            this.Text = "Збереження";
            this.Load += new System.EventHandler(this.Formzber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private odbcDataSet odbcDataSet;
        private System.Windows.Forms.BindingSource adrBindingSource;
        private odbcDataSetTableAdapters.adrTableAdapter adrTableAdapter;
        private System.Windows.Forms.BindingSource posBindingSource;
        private odbcDataSetTableAdapters.posTableAdapter posTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private mysqlDataSet mysqlDataSet;
        private System.Windows.Forms.BindingSource posBindingSource1;
        private mysqlDataSetTableAdapters.posTableAdapter posTableAdapter1;
    }
}