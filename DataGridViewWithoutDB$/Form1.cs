using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewWithoutDB_
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("firstName", Type.GetType("System.String"));
            table.Columns.Add("LastName", Type.GetType("System.String"));
            table.Columns.Add("Sum", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtID.Text, txtFirstName.Text, txtLastName.Text,txtSum.Text );
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtSum.Text = String.Empty;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];    
            txtID.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtSum.Text = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtID.Text;
            newdata.Cells[1].Value = txtFirstName.Text;
            newdata.Cells[2].Value = txtLastName.Text;
            newdata.Cells[3].Value = txtSum.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
