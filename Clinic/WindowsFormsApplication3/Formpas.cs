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
    public partial class Formpas : Form
    {
        public Formpas()
        {
            InitializeComponent();
        }

        private void Formpas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mysqlDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.mysqlDataSet.adr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.hvorobu". При необходимости она может быть перемещена или удалена.
            this.hvorobuTableAdapter.Fill(this.odbcDataSet.hvorobu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);
      
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adm". При необходимости она может быть перемещена или удалена.
            this.admTableAdapter.Fill(this.odbcDataSet.adm);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {label3.Visible=true;
        string p; p = textBox2.Text.Trim();
        if (textBox1.Text == label3.Text)
        {


            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("UPDATE adm " + " SET passord ='" + p + "'" + " WHERE (((kodpas)=\"" + 1 + "\"));", c);
            c.Open();
            OdbcDataReader reader = query.ExecuteReader();
            try { }
            catch { }
            finally { reader.Close(); } c.Close();
            admTableAdapter.Fill(odbcDataSet.adm);
            label3.Visible = false;
            MessageBox.Show("ваш пароль змінено на " + textBox2.Text);
            this.Close();
        }
        else { MessageBox.Show("невірний старий пароль " ); }
        label3.Visible = false; 
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        } 
    }
}
