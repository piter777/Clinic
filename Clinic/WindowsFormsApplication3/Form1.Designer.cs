namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінаПаролюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кабінетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.працівникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паціентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаХворобToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гафікПриходуНаРоботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.збереженняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.odbcDataSet = new WindowsFormsApplication3.odbcDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.adrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adrTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.adrTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new WindowsFormsApplication3.odbcDataSetTableAdapters.TableAdapterManager();
            this.admBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admTableAdapter = new WindowsFormsApplication3.odbcDataSetTableAdapters.admTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.записиToolStripMenuItem,
            this.таблиціToolStripMenuItem,
            this.отчетиToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.збереженняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem,
            this.змінаПаролюToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // змінаПаролюToolStripMenuItem
            // 
            this.змінаПаролюToolStripMenuItem.Name = "змінаПаролюToolStripMenuItem";
            this.змінаПаролюToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.змінаПаролюToolStripMenuItem.Text = "Зміна паролю";
            this.змінаПаролюToolStripMenuItem.Click += new System.EventHandler(this.змінаПаролюToolStripMenuItem_Click);
            // 
            // записиToolStripMenuItem
            // 
            this.записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            this.записиToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.записиToolStripMenuItem.Text = "Записи";
            this.записиToolStripMenuItem.Click += new System.EventHandler(this.записиToolStripMenuItem_Click);
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.адресиToolStripMenuItem,
            this.кабінетиToolStripMenuItem,
            this.працівникиToolStripMenuItem,
            this.паціентиToolStripMenuItem,
            this.базаХворобToolStripMenuItem,
            this.гафікПриходуНаРоботуToolStripMenuItem});
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            this.таблиціToolStripMenuItem.Click += new System.EventHandler(this.таблиціToolStripMenuItem_Click);
            // 
            // адресиToolStripMenuItem
            // 
            this.адресиToolStripMenuItem.Name = "адресиToolStripMenuItem";
            this.адресиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.адресиToolStripMenuItem.Text = "Адреси";
            this.адресиToolStripMenuItem.Click += new System.EventHandler(this.адресиToolStripMenuItem_Click);
            // 
            // кабінетиToolStripMenuItem
            // 
            this.кабінетиToolStripMenuItem.Name = "кабінетиToolStripMenuItem";
            this.кабінетиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.кабінетиToolStripMenuItem.Text = "Посади";
            this.кабінетиToolStripMenuItem.Click += new System.EventHandler(this.кабінетиToolStripMenuItem_Click);
            // 
            // працівникиToolStripMenuItem
            // 
            this.працівникиToolStripMenuItem.Name = "працівникиToolStripMenuItem";
            this.працівникиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.працівникиToolStripMenuItem.Text = "Працівники";
            this.працівникиToolStripMenuItem.Click += new System.EventHandler(this.працівникиToolStripMenuItem_Click);
            // 
            // паціентиToolStripMenuItem
            // 
            this.паціентиToolStripMenuItem.Name = "паціентиToolStripMenuItem";
            this.паціентиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.паціентиToolStripMenuItem.Text = "Паціенти";
            this.паціентиToolStripMenuItem.Click += new System.EventHandler(this.паціентиToolStripMenuItem_Click);
            // 
            // базаХворобToolStripMenuItem
            // 
            this.базаХворобToolStripMenuItem.Name = "базаХворобToolStripMenuItem";
            this.базаХворобToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.базаХворобToolStripMenuItem.Text = "база Хвороб";
            this.базаХворобToolStripMenuItem.Click += new System.EventHandler(this.базаХворобToolStripMenuItem_Click);
            // 
            // гафікПриходуНаРоботуToolStripMenuItem
            // 
            this.гафікПриходуНаРоботуToolStripMenuItem.Name = "гафікПриходуНаРоботуToolStripMenuItem";
            this.гафікПриходуНаРоботуToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.гафікПриходуНаРоботуToolStripMenuItem.Text = "Гафік приходу на роботу";
            this.гафікПриходуНаРоботуToolStripMenuItem.Click += new System.EventHandler(this.гафікПриходуНаРоботуToolStripMenuItem_Click);
            // 
            // отчетиToolStripMenuItem
            // 
            this.отчетиToolStripMenuItem.Name = "отчетиToolStripMenuItem";
            this.отчетиToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.отчетиToolStripMenuItem.Text = "Звіти";
            this.отчетиToolStripMenuItem.Click += new System.EventHandler(this.отчетиToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.проПрограмуToolStripMenuItem.Text = "про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // збереженняToolStripMenuItem
            // 
            this.збереженняToolStripMenuItem.Name = "збереженняToolStripMenuItem";
            this.збереженняToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.збереженняToolStripMenuItem.Text = "Конвертація";
            this.збереженняToolStripMenuItem.Visible = false;
            this.збереженняToolStripMenuItem.Click += new System.EventHandler(this.збереженняToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " пароль";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // odbcDataSet
            // 
            this.odbcDataSet.DataSetName = "odbcDataSet";
            this.odbcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "ентер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admBindingSource, "kodpas", true));
            this.textBox1.Location = new System.Drawing.Point(92, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизація";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логін";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.odbcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Стоматоголічна база даних";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odbcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adrBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private odbcDataSet odbcDataSet;
        private System.Windows.Forms.BindingSource adrBindingSource;
        private odbcDataSetTableAdapters.adrTableAdapter adrTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кабінетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem працівникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паціентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаХворобToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem збереженняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гафікПриходуНаРоботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem змінаПаролюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private odbcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource admBindingSource;
        private odbcDataSetTableAdapters.admTableAdapter admTableAdapter;
    }
}

