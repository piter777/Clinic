using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.Odbc;



namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adm". При необходимости она может быть перемещена или удалена.
            this.admTableAdapter.Fill(this.odbcDataSet.adm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adm". При необходимости она может быть перемещена или удалена.
            this.admTableAdapter.Fill(this.odbcDataSet.adm);
            this.admTableAdapter.Fill (this.odbcDataSet.adm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.odbcDataSet.adr);
          

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void adrBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void адресиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formadr Forma = new Formadr();
            Forma.MdiParent = this;
            Forma.Show();
        }

        private void кабінетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formpos Forma = new Formpos();
            Forma.MdiParent = this;
            Forma.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void таблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Formzapis DEmployee = new Formzapis();
            DEmployee.MdiParent = this;
            DEmployee.Show();
            
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void працівникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdoc DEmployee = new Formdoc();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void паціентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formpac DEmployee = new Formpac();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void медКарткиПаціентівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlic DEmployee = new Formlic();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void базаХворобToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formhvor DEmployee = new Formhvor();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void отчетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlic DEmployee = new Formlic();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void збереженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formzber DEmployee = new Formzber();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void гафікПриходуНаРоботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formgraf DEmployee = new Formgraf();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ця програма створення для ведення учета в стоматологічному кабінту по паціентам та графіку роботи працівників");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            if (textBox1.Text == textBox2.Text) { menuStrip1.Visible = true; textBox1.Visible = false;
            button1.Visible = false; label2.Visible = false; groupBox1.Visible = false;
            }
            textBox2.Visible = false;
        }

        private void змінаПаролюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formpas DEmployee = new Formpas();
            DEmployee.MdiParent = this;
            DEmployee.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 Forma = new Form2();
            Forma.MdiParent = this;
            Forma.Show();
        }
    }
}
