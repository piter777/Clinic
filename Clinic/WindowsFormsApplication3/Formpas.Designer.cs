namespace WindowsFormsApplication3
{
    partial class Formpas
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
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odbcDataSet = new WindowsFormsApplication3.odbcDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.admBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.admTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.likBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.likTableAdapter();
            this.docTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.docTableAdapter();
            this.hvorobuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hvorobuTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.hvorobuTableAdapter();
            this.mysqlDataSet = new WindowsFormsApplication3.mysqlDataSet();
            this.adrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adrTableAdapter = new WindowsFormsApplication3.mysqlDataSetTableAdapters.adrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "ентер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ведіть  старий пароль";
            // 
            // admBindingSource
            // 
            this.admBindingSource.DataMember = "adm";
            this.admBindingSource.DataSource = this.odbcDataSet;
            // 
            // admTableAdapter
            // 
            this.admTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ведіть  новий пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admBindingSource, "passord", true));
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            this.label3.Visible = false;
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
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // hvorobuBindingSource
            // 
            this.hvorobuBindingSource.DataMember = "hvorobu";
            this.hvorobuBindingSource.DataSource = this.odbcDataSet;
            // 
            // hvorobuTableAdapter
            // 
            this.hvorobuTableAdapter.ClearBeforeFill = true;
            // 
            // mysqlDataSet
            // 
            this.mysqlDataSet.DataSetName = "mysqlDataSet";
            this.mysqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adrBindingSource
            // 
            this.adrBindingSource.DataMember = "adr";
            this.adrBindingSource.DataSource = this.mysqlDataSet;
            // 
            // adrTableAdapter
            // 
            this.adrTableAdapter.ClearBeforeFill = true;
            // 
            // Formpas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 92);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "Formpas";
            this.Text = "Зміна паролю";
            this.Load += new System.EventHandler(this.Formpas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private odbcDataSet odbcDataSet;
        private System.Windows.Forms.BindingSource admBindingSource;
        private odbcDataSetTableAdapters.admTableAdapter admTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource likBindingSource;
        private odbcDataSetTableAdapters.likTableAdapter likTableAdapter;
        private System.Windows.Forms.BindingSource docBindingSource;
        private odbcDataSetTableAdapters.docTableAdapter docTableAdapter;
        private System.Windows.Forms.BindingSource hvorobuBindingSource;
        private odbcDataSetTableAdapters.hvorobuTableAdapter hvorobuTableAdapter;
        private System.Windows.Forms.BindingSource adrBindingSource;
        private mysqlDataSet mysqlDataSet;
        private mysqlDataSetTableAdapters.adrTableAdapter adrTableAdapter;
    }
}