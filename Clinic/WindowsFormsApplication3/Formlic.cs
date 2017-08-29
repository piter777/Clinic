using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Formlic : Form
    {
        public Formlic()
        {
            InitializeComponent();
        }

        private void Formlic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.lik". При необходимости она может быть перемещена или удалена.
            this.likTableAdapter.Fill(this.odbcDataSet.lik);
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.pac". При необходимости она может быть перемещена или удалена.
            this.pacTableAdapter.Fill(this.odbcDataSet.pac);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "odbcDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.odbcDataSet.doc);

           this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
           reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            reportViewer4.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = true;
            reportViewer1.Visible = false;
            reportViewer3.Visible = false;
            reportViewer4.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            reportViewer3.Visible = true;
           reportViewer2.Visible = false;
            reportViewer1.Visible = false;
           reportViewer4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer4.Visible = true;
            reportViewer2.Visible = false;
            reportViewer1.Visible = false;
            reportViewer3.Visible = false;
        }
    }
}
