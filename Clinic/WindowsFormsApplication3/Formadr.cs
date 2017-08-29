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
    public partial class Formadr : Form
    {
        public Formadr()
        {
            InitializeComponent();
        }

        private void Formadr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.graf". При необходимости она может быть перемещена или удалена.
            this.grafTableAdapter.Fill(this.odbcDataSet.graf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.odbcDataSet.adr);
            listBox1.DataSource = adrBindingSource;
            listBox1.DisplayMember = "koda";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM adr WHERE koda = " + textBox2.Text, c);
            c.Open();OdbcDataReader reader = query.ExecuteReader();
             try { } catch{ }finally {reader.Close();  }  c.Close();
            adrTableAdapter.Fill(odbcDataSet.adr);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

     
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("INSERT INTO adr(kraina,misto,vylica,dom,kabinet) " + "VALUES ('" + textBox3.Text + "' ,'" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "');", c);    
            c.Open();  OdbcDataReader reader = query.ExecuteReader();
            try { }  catch { }   finally { reader.Close(); }  c.Close();
            adrTableAdapter.Fill(odbcDataSet.adr);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE adr " + " SET kraina =  ' " + textBox3.Text + " ', misto = ' " + textBox4.Text + " ', vylica = ' " + textBox5.Text + " ' ,  dom = ' " + textBox6.Text + " ' ,kabinet =  ' " + textBox7.Text + "'" + " WHERE (((koda)=\"" + textBox2.Text + "\"));", c);
             c.Open(); 
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            adrTableAdapter.Fill(odbcDataSet.adr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
