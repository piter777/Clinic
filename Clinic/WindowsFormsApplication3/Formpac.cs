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
    public partial class Formpac : Form
    {
        public Formpac()
        {
            InitializeComponent();
        }

        private void Formpac_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet1.pac". При необходимости она может быть перемещена или удалена.
            this.pacTableAdapter.Fill(this.odbcDataSet1.pac);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet1.lik". При необходимости она может быть перемещена или удалена.
            this.likTableAdapter1.Fill(this.odbcDataSet1.lik);
            
            this.pacTableAdapter.Fill(this.odbcDataSet.pac);
            listBox1.DataSource = pacBindingSource;
            listBox1.DisplayMember = "last";
            listBox2.DataSource = likBindingSource;
            listBox2.DisplayMember = "liku";
    

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
          likBindingSource.Filter = "last like '%" + textBox9.Text + "%'";
                
            }

            catch (Exception) { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           pacBindingSource.Filter = "last like '%" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        /*    OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("INSERT INTO doc(last,first,middle,phone,graf,lic,kodpos,koda) " + "VALUES ('" + textBox2.Text + "' , '" + textBox3.Text + "','" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "' ,'" + textBox7.Text + "' ,'" + textBox8.Text + "' ,  '" + textBox9.Text + "');", c);

            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            docTableAdapter.Fill(odbcDataSet.doc);*/
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")) { MessageBox.Show("якесь поле пусте"); }
            else
            {

                OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
                OdbcCommand query = new OdbcCommand("INSERT INTO pac(last,first,middle) " + "VALUES ('" + textBox2.Text + "' , '" + textBox3.Text + "','" + textBox4.Text + "' );", c);
                c.Open(); OdbcDataReader reader = query.ExecuteReader();
                try { }
                catch { }
                finally { reader.Close(); } c.Close();
                pacTableAdapter.Fill(odbcDataSet.pac);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM pac WHERE kodp = " + textBox1.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            pacTableAdapter.Fill(odbcDataSet.pac);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")) { MessageBox.Show("якесь поле пусте"); }
            else
            {
                OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
                OdbcCommand query = new OdbcCommand("UPDATE pac " + " SET last =  '" + textBox2.Text + "',   first = '" + textBox3.Text + " ',   middle = '" + textBox4.Text + "'" + " WHERE (((kodp)=\"" + textBox1.Text + "\"));", c);
                c.Open(); OdbcDataReader reader = query.ExecuteReader();
                try { }
                catch { }
                finally { reader.Close(); } c.Close();
            }
            /*
            pacTableAdapter.Fill(odbcDataSet.pac);
            OdbcConnection cc = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand queryc = new OdbcCommand("UPDATE lik " + " SET last =  ' " + textBox8.Text +  "'" + " WHERE (((kodp)=\"" + textBox1.Text + "\"));", c);
            c.Open(); OdbcDataReader readerc = queryc.ExecuteReader();
            try { }
            catch { }
            finally { readerc.Close(); } c.Close();
            pacTableAdapter.Fill(odbcDataSet.pac);*/
     
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pacBindingSource.Sort = "last ASC ";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pacBindingSource.Sort = "last DESC ";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pacBindingSource.Position = pacBindingSource.Find("last", toolStripTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
            string a;
            a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day));

            DateTime date2 = Convert.ToDateTime(dateTimePicker2.Text);
            string b;
            b = (Convert.ToString(date2.Year) + '.' + Convert.ToString(date2.Month) + '.' + Convert.ToString(date2.Day));

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString); 
            OdbcCommand query = new OdbcCommand("INSERT INTO lik(pochv,kinhv,kodhv,kodp,liku,last) " + "VALUES ('" + a + "' , '" + b + "','" + textBox6.Text + "','" + textBox9.Text + "','" + richTextBox1.Text + "','" + textBox2.Text + "' );", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            likTableAdapter1.Fill(odbcDataSet.lik);
            likBindingSource.Filter = "last like '%" + "" + "%'";
            likBindingSource.Filter = "last like '%" + textBox2.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM lik WHERE kodl = " + textBox8.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            likTableAdapter1.Fill(odbcDataSet.lik);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);   string a;  a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day));
             DateTime date2 = Convert.ToDateTime(dateTimePicker2.Text); string b;   b = (Convert.ToString(date2.Year) + '.' + Convert.ToString(date2.Month) + '.' + Convert.ToString(date2.Day));

          





            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE lik " + " SET pochv =  '" + a + "',   kinhv = '" + b + " ',  kodhv = '" +textBox6.Text + "',  kodp = '" + textBox9.Text + "',  liku = '" + richTextBox1.Text + "',  last = '" + textBox2.Text + "'" + " WHERE (((kodl)=\"" + textBox8.Text + "\"));", c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
         //   likTableAdapter.Fill(odbcDataSet.lik);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            likBindingSource.Filter = "last like '%" + "" + "%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             double s;
            int k = 0; int n = listBox2.Items.Count;
            for (int i = 0; i < n; i++)
            {
                listBox2.SelectedIndex = i;
                if (checkBox1.Checked==true)
                {
                    k ++;
                }
            } s = k;
            s=(s/n)*100;
            
            MessageBox.Show(" ефективність лікування " + Convert.ToInt32(s) + "%" );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
