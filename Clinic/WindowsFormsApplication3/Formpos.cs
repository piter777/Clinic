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
    public partial class Formpos : Form
    {
        public Formpos()
        {
            InitializeComponent();
        }

        private void Formpos_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.pos". При необходимости она может быть перемещена или удалена.
            this.posTableAdapter.Fill(this.odbcDataSet.pos);

            listBox1.DataSource = posBindingSource;
            listBox1.DisplayMember = "nazva";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM pos WHERE kodpos = " + textBox1.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            posTableAdapter.Fill(odbcDataSet.pos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("INSERT INTO pos(nazva,vimogi,oklad) " + "VALUES ( '" + textBox2.Text + "', '" + richTextBox1.Text + "', '" + textBox3.Text + "');", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            posTableAdapter.Fill(odbcDataSet.pos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE pos " + " SET nazva =  ' " + textBox2.Text + " ', vimogi = ' " + richTextBox1.Text + " ', oklad = ' " + textBox3.Text + "'" + " WHERE (((kodpos)=\"" + textBox1.Text + "\"));", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            posTableAdapter.Fill(odbcDataSet.pos);
        }
    }
}
