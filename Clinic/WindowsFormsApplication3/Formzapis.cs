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
    public partial class Formzapis : Form
    {
        public Formzapis()
        {
            InitializeComponent();
        }

        private void Formzapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.pac". При необходимости она может быть перемещена или удалена.
            this.pacTableAdapter.Fill(this.odbcDataSet.pac);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.odbcDataSet.adr);
            
            this.zapisTableAdapter.Fill(this.odbcDataSet.zapis);

         
            listBox1.DataSource = zapisBindingSource;
            listBox1.DisplayMember = "zapd";
            listBox2.DataSource = pacBindingSource;
            listBox2.DisplayMember = "kodp";
            listBox3.DataSource = docBindingSource;
            listBox3.DisplayMember = "kodd";
        
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            try
            {
                DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
                dateTimePicker2.Text = dateTimePicker1.Text;
                textBox8.Text = textBox2.Text;
                textBox10.Text =Convert.ToString(  listBox1.SelectedIndex );
                textBox5.Visible = true;
                textBox4.Visible = true;
                int k = 0; int n = listBox2.Items.Count;
                for (int i = 0; i < n; i++)
                {
                    listBox2.SelectedIndex = i;
                    if (Convert.ToInt32(textBox5.Text) == Convert.ToInt32(listBox2.Text)) {
                        k = i;  } }
                listBox2.SelectedIndex = k;

                int k1 = 0; int n1 = listBox3.Items.Count;
                for (int i1 = 0; i1 < n1; i1++)
                {
                    listBox3.SelectedIndex = i1;
                    if (Convert.ToInt32(textBox4.Text) == Convert.ToInt32(listBox3.Text))
                    {
                        k1 = i1;
                    }
                }
                listBox3.SelectedIndex = k1;

                textBox5.Visible = false;
                textBox4.Visible = false;
            }

            catch (Exception) { }

          
            
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = listBox2.Items.Count; string a; string aa; string t = textBox9.Text; string t1 = textBox3.Text;
            int nn = listBox1.Items.Count; int pp =Convert.ToInt32( textBox10.Text);
            string doc = comboBox1.Text;

        DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text); int pr = 0; int ia=0; int ib=0;
        a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day));
        DateTime date3 = Convert.ToDateTime(dateTimePicker1.Text); 
        aa = (Convert.ToString(date3.Year) + '.' + Convert.ToString(date3.Month) + '.' + Convert.ToString(date3.Day));
        dateTimePicker1.Text = dateTimePicker2.Text;
        string sc = textBox2.Text;
        string sa = textBox2.Text; textBox2.Text = textBox8.Text;
            if ((textBox2.Text == "") || (comboBox2.Text == "") || (comboBox1.Text == "")) { MessageBox.Show("не всі головні поля заповнені"); }
            else
            {
                DateTime date2;
                int z = listBox1.SelectedIndex;
                string tt = textBox2.Text;
                for (int i = 0; i < nn; i++)
                {
                 
                    listBox1.SelectedIndex = i;
                   
                   date2 = Convert.ToDateTime(dateTimePicker1.Text);
                   if (i == pp) { dateTimePicker1.Text = dateTimePicker2.Text; }
                   if ((date2.Year == date1.Year) && (date2.Month == date1.Month) && (date2.Day == date1.Day))
                   {
                       
                       
                       string sb = textBox2.Text; 
                       ia = Convert.ToInt32(sa[0]) * 10 + Convert.ToInt32(sa[1]);
                       ib = Convert.ToInt32(sb[0]) * 10 + Convert.ToInt32(sb[1]);
                       ia = ia * 60 + Convert.ToInt32(sa[3]) * 10 + Convert.ToInt32(sa[4]);
                       ib = ib * 60 + Convert.ToInt32(sb[3]) * 10 + Convert.ToInt32(sb[4]);
                     //  if (ib==ia) { pr++; MessageBox.Show(pr + "ia=" + ia + "ib=" + ib); } 
                       if ((ia > (ib + 30)) || (ia < (ib - 30))) { }
                       else
                       {
                           if (doc == comboBox1.Text) { pr++; }
                           
                           
                           
                           }
                   }
                }if (pr>0){MessageBox.Show("увага ви записали паціента одночасно з іншим паціентом на одного доктора  ");}
                pr = 0;
                listBox1.SelectedIndex = z;










            
                int s = Convert.ToInt32(t);  int l = listBox1.SelectedIndex;  listBox1.SelectedIndex = 0;
                int k = 0;   for (int i = 0; i < n; i++)
                { listBox2.SelectedIndex = i; if (s == Convert.ToInt32(t))  { k++; } }
                listBox1.SelectedIndex = l; if (k > 0) {
                        

                    OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
                    OdbcCommand query = new OdbcCommand("INSERT INTO zapis(zapv,zapd,kodd,zamitka,kodp) " + "VALUES ('" + sc + "' ,'" + aa + "', '" + t1 + "', '" + richTextBox1.Text + "', '" + t + "');", c);
                    c.Open(); OdbcDataReader reader = query.ExecuteReader();
                    try { }
                    catch { }
                    finally { reader.Close(); } c.Close();
                    zapisTableAdapter.Fill(odbcDataSet.zapis);
                }
                else { MessageBox.Show("Невірний код піціента"); }
                k = 0;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("DELETE FROM zapis WHERE kodz = " + textBox1.Text, c);
            c.Open(); OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            zapisTableAdapter.Fill(odbcDataSet.zapis);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = listBox2.Items.Count; string a; string aa; string t = textBox9.Text; string t1 = textBox3.Text;
            int nn = listBox1.Items.Count; int pp =Convert.ToInt32( textBox10.Text);
            string doc = comboBox1.Text;

        DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text); int pr = 0; int ia=0; int ib=0;
        a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day));
        DateTime date3 = Convert.ToDateTime(dateTimePicker1.Text); 
        aa = (Convert.ToString(date3.Year) + '.' + Convert.ToString(date3.Month) + '.' + Convert.ToString(date3.Day));
        dateTimePicker1.Text = dateTimePicker2.Text;
        string sc = textBox2.Text;
        string sa = textBox2.Text; textBox2.Text = textBox8.Text;
        if ((textBox2.Text == "") || (comboBox2.Text == "") || (comboBox1.Text == "")) { MessageBox.Show("не всі головні поля заповнені"); }
        else
        {
            DateTime date2;
            int z = listBox1.SelectedIndex;
            string tt = textBox2.Text;
            for (int i = 0; i < nn; i++)
            {

                listBox1.SelectedIndex = i;

                date2 = Convert.ToDateTime(dateTimePicker1.Text);
                if (i == pp) { dateTimePicker1.Text = dateTimePicker2.Text; }
                if ((date2.Year == date1.Year) && (date2.Month == date1.Month) && (date2.Day == date1.Day))
                {


                    string sb = textBox2.Text;
                    ia = Convert.ToInt32(sa[0]) * 10 + Convert.ToInt32(sa[1]);
                    ib = Convert.ToInt32(sb[0]) * 10 + Convert.ToInt32(sb[1]);
                    ia = ia * 60 + Convert.ToInt32(sa[3]) * 10 + Convert.ToInt32(sa[4]);
                    ib = ib * 60 + Convert.ToInt32(sb[3]) * 10 + Convert.ToInt32(sb[4]);
                    //  if (ib==ia) { pr++; MessageBox.Show(pr + "ia=" + ia + "ib=" + ib); } 
                    if ((ia > (ib + 30)) || (ia < (ib - 30))) { }
                    else
                    {
                        if (doc == comboBox1.Text) { pr++; }



                    }
                }
            } if (pr > 0) { MessageBox.Show("увага ви записали паціента одночасно з іншим паціентом на одного доктора  "); }
            pr = 0;
            listBox1.SelectedIndex = z;

            string t2 = textBox9.Text;
            string t11 = textBox3.Text;

          

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE zapis " + " SET zapv =  ' " + sc + " ', zapd = ' " + aa + " ', kodd = ' " + t11 + " ' ,  zamitka = ' " + richTextBox1.Text + " ' ,kodp =  ' " + t2 + "'" + " WHERE (((kodz)=\"" + textBox1.Text + "\"));", c);
            c.Open();
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            zapisTableAdapter.Fill(odbcDataSet.zapis);
        }}
        

        private void button4_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {


            listBox1.DataBindings.Clear();
            
            listBox1.Refresh();
           

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zapisTableAdapter.FillBy(this.odbcDataSet.zapis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      

        private void button4_Click_4(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("SELECT 'zapd' FROM 'stomatolog'.'zapis' WHERE ('zapd' > 11.10.2011) OR ('zapd' < 11.10.2012);", c); c.Open();
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            zapisTableAdapter.Fill(odbcDataSet.zapis);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zapisBindingSource.Filter = "kodp like '%" + Convert.ToInt32(textBox9.Text) + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zapisBindingSource.Filter = "kodd like '%" + textBox3.Text + "%'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zapisBindingSource.Filter = "kodp like '%" +"" + "%'";
        }

        private void button9_Click(object sender, EventArgs e)
        {
             try
            {zapisBindingSource.Filter = "CONVERT(kodp, 'System.String') LIKE '%" + textBox9.Text + "%'";
            if (listBox1.Items.Count > 0) listBox1.SelectedIndex = 0;
            }
             catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                zapisBindingSource.Filter = "CONVERT(kodd, 'System.String') LIKE '%" + textBox3.Text + "%'";
                listBox1.SelectedIndex = 0;
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zapisBindingSource.Filter = "zamitka like '%" + "" + "%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);

            date1 = Convert.ToDateTime(System.DateTime.Now);
            richTextBox2.Text = Convert.ToString(date1);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a;
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
         string c;
            a = (Convert.ToString(date1.Year) + '.' + Convert.ToString(date1.Month) + '.' + Convert.ToString(date1.Day));
            string b = textBox2.Text; 
            c=textBox2.Text;
            richTextBox2.Text = Convert.ToString(c[0]) +Convert.ToString( c[1]);

        }

        private void button13_Click(object sender, EventArgs e)
        {    int nn = listBox1.Items.Count;
       
        string t2 = textBox9.Text;
        string t11 = textBox3.Text;

        for (int i = 0; i < nn; i++)
        {
            
            listBox1.SelectedIndex = 0;

           
            string sc = textBox2.Text;
            DateTime date3 = Convert.ToDateTime(dateTimePicker1.Text);
            string aa = (Convert.ToString(date3.Year) + '.' + Convert.ToString(date3.Month) + '.' + Convert.ToString(date3.Day));

            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE zapis " + " SET zapv =  ' " + sc + " ', zapd = ' " + aa + " ', kodd = ' " + t11 + " ' ,  zamitka = ' " + richTextBox1.Text + " ' ,kodp =  ' " + t2 + "'" + " WHERE (((kodz)=\"" + textBox1.Text + "\"));", c);
            c.Open();
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            zapisTableAdapter.Fill(odbcDataSet.zapis);
        }
      
        try
        {
            zapisBindingSource.Filter = "CONVERT(kodd, 'System.String') LIKE '%" + textBox3.Text + "%'";
            listBox1.SelectedIndex = 0;
        }
        catch { }
        MessageBox.Show("Всі паціенти були перенесені на іншого доктора з іхнім часом");


        }
    }
}
