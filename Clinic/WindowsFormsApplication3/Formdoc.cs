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
    public partial class Formdoc : Form
    {
        public Formdoc()
        {
            InitializeComponent();
        }

        private void Formdoc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.odbcDataSet.adr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.pos". При необходимости она может быть перемещена или удалена.
            this.posTableAdapter.Fill(this.odbcDataSet.pos);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);
            listBox1.DataSource = docBindingSource;
            listBox1.DisplayMember = "last";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "")) { MessageBox.Show("якесь поле пусте"); }
            else
            {
                OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
                OdbcCommand query = new OdbcCommand("INSERT INTO doc(last,first,middle,phone,graf,lic,kodpos,koda) " + "VALUES ('" + textBox2.Text + "' , '" + textBox3.Text + "','" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "' ,'" + textBox7.Text + "' ,'" + textBox8.Text + "' ,  '" + textBox9.Text + "');", c);

                c.Open(); OdbcDataReader reader = query.ExecuteReader();
                try { }
                catch { }
                finally { reader.Close(); } c.Close();
                docTableAdapter.Fill(odbcDataSet.doc);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM doc WHERE kodd = " + textBox1.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            docTableAdapter.Fill(odbcDataSet.doc);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE doc " + " SET last =  ' " + textBox2.Text + " ',   first = ' " + textBox3.Text + " ',   middle = ' " + textBox4.Text + " ',   phone = ' " + textBox5.Text + " ',   graf = ' " + textBox6.Text + " ',   lic = ' " + textBox7.Text + " ',   kodpos = ' " + textBox8.Text + " ' koda =  ' " + textBox9.Text + "'" + " WHERE (((kodd)=\"" + textBox1.Text + "\"));", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            docTableAdapter.Fill(odbcDataSet.doc);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            docBindingSource.Sort = "last ASC ";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            docBindingSource.Sort = "last DESC";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           docBindingSource.Filter = "last like '%" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            docBindingSource.Position = docBindingSource.Find("last", toolStripTextBox1.Text);
        }
    }
}
