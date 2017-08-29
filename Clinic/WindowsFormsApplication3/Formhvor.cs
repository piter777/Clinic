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
    public partial class Formhvor : Form
    {
        public Formhvor()
        {
            InitializeComponent();
        }

        private void Formhvor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter.Fill(this.odbcDataSet.hvorobu);
            listBox1.DataSource = hvorobuBindingSource;
            listBox1.DisplayMember = "nazva";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("INSERT INTO hvorobu(nazva,opis,simpt,liku) " + "VALUES ('" + textBox2.Text + "' , '" + richTextBox1.Text + "','" + richTextBox2.Text + "' ,'" + richTextBox3.Text + "');", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            hvorobuTableAdapter.Fill(odbcDataSet.hvorobu);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE hvorobu " + " SET nazva =  '" + textBox2.Text + "',   opis = '" + richTextBox1.Text + " ',   simpt = '" + richTextBox2.Text + "' ,   liku = '" + richTextBox3.Text + "'" + " WHERE (((kodhv)=\"" + textBox1.Text + "\"));", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            hvorobuTableAdapter.Fill(odbcDataSet.hvorobu);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM hvorobu WHERE kodhv = " + textBox1.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            hvorobuTableAdapter.Fill(odbcDataSet.hvorobu);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            hvorobuBindingSource.Sort = "nazva ASC ";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            hvorobuBindingSource.Sort = "nazva DESC ";
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            hvorobuBindingSource.Filter = "nazva like '%" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            hvorobuBindingSource.Position = hvorobuBindingSource.Find("nazva", toolStripTextBox1.Text);
        }
    }
}
