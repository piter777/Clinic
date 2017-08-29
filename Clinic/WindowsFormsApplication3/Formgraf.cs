using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.Odbc;


namespace WindowsFormsApplication3
{
    public partial class Formgraf : Form
    {
        public Formgraf()
        {
            InitializeComponent();
        }

        private void Formgraf_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.graf". При необходимости она может быть перемещена или удалена.
            this.grafTableAdapter.Fill(this.odbcDataSet.graf);
            listBox2.DataSource = grafBindingSource;
            listBox2.DisplayMember = "kodg";
            listBox1.DataSource = docBindingSource;
            listBox1.DisplayMember = "kodd";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            int k; string a;
            if (checkBox1.Checked == true) { k = 1; }
            else k = 0;
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
            a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day)); 
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("INSERT INTO graf(kodd,date,zap,spr) " + "VALUES ('" + textBox10.Text + "' ,'" + a + "', '" + richTextBox1.Text + "', '" + k + "');", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            grafTableAdapter.Fill(odbcDataSet.graf);
            textBox10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM graf WHERE kodg = " + textBox11.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            grafTableAdapter.Fill(odbcDataSet.graf);
            textBox10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            int k; string a;
            if (checkBox1.Checked == true) { k = 1; }
            else k = 0;
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
            a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day)); 
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
                                                //("INSERT INTO graf(kodd,date,zap,spr) " + "VALUES ('" + textBox10.Text + "' ,'" + a + "', '" + richTextBox1.Text + "', '" + k + "');", c);
            OdbcCommand query = new OdbcCommand("UPDATE graf " + " SET kodd =  ' " + textBox10.Text + " ', date = ' " + a + " ', zap = ' " + richTextBox1.Text + " ' ,  spr = ' " + k + " ' " + " WHERE (((kodg)=\"" + textBox11.Text + "\"));", c);
            c.Open();
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            grafTableAdapter.Fill(odbcDataSet.graf);
            textBox10.Visible = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { try
            {
       
                textBox1.Visible = true;
                int k = 0; int n = listBox1.Items.Count;
                for (int i = 0; i < n; i++)
                {
                    listBox1.SelectedIndex = i;
                    if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(listBox1.Text)) {
                        k = i;  } }
                listBox1.SelectedIndex = k;
          
            }

        catch (Exception) { }
        }
    }
}
