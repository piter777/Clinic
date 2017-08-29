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
using MySql;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;



namespace WindowsFormsApplication3
{
    public partial class Formzber : Form
    {
        public Formzber()
        {
            InitializeComponent();
        }

        private void Formzber_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mysqlDataSet.pos". При необходимости она может быть перемещена или удалена.
            this.posTableAdapter1.Fill(this.mysqlDataSet.pos);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.pos". При необходимости она может быть перемещена или удалена.
            this.posTableAdapter.Fill(this.odbcDataSet.pos);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.adr". При необходимости она может быть перемещена или удалена.
            this.adrTableAdapter.Fill(this.odbcDataSet.adr);

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 20;
            ExcelApp.Cells[2, 2] = "назва";
            ExcelApp.Cells[2, 3] = "вимоги";
            ExcelApp.Cells[2, 4] = "оклад";

            var ex = ExcelWorkSheet.get_Range("A1", "g1");
            ex.Merge(Type.Missing);
            ex.Borders.ColorIndex = 1;
            ex.Font.Size = 25;
            ExcelApp.Cells[1, 1] = "Звіт по професіям";
            int wid = dataGridView2.Rows.Count + 2;
            ex = ExcelWorkSheet.get_Range("A2", "g" + wid.ToString());
            ex.Borders.ColorIndex = 1;
            ex.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ex.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;
            ex = ExcelWorkSheet.get_Range("A1", "g" + wid.ToString());
            ex.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            ex.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                ExcelApp.Cells[i + 2, 1] = i + 1;
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {

                    ExcelApp.Cells[i + 3, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection c = new MySqlConnection(Properties.Settings.Default.mysqlConnectionString);
            MySqlCommand query;
            query = new MySqlCommand("`sele``", c);
            query.CommandType = CommandType.StoredProcedure;
            query.CommandText = "`sele`";
            c.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(query.ExecuteReader());
            c.Close();
            dataGridView2.DataBindings.Clear();
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "nazva";
            dataGridView2.Columns[2].HeaderText = "vimogi";
            dataGridView2.Columns[3].HeaderText = "oklad";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection c = new OdbcConnection(Properties.Settings.Default.odbcConnectionString);
            OdbcCommand query = new OdbcCommand("`stomatolog`.`sele`", c);
            query.CommandType = CommandType.StoredProcedure;
            query.CommandText = "`stomatolog`.`sele`";
            c.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(query.ExecuteReader());
            c.Close();
            dataGridView2.DataBindings.Clear();
            dataGridView2.DataSource = dt;
            //  adrTableAdapter.Fill(odbcDataSet.adr);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
