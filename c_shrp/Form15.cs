using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form15 : Form
    {

        OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\kits_n_expenses.accdb");
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                c.Open();
                DataSet ds = new DataSet();
                string query = "select * from kits where Name = @ab ";
                OleDbCommand cmd = new OleDbCommand(query, c);
                cmd.Parameters.Add("@ab", OleDbType.VarChar,255).Value = textBox1.Text.ToString();
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                /*ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.Fill(dt);*/
                dataGridView1.DataSource = dt.DefaultView;
                c.Close();
            }
            else if (radioButton2.Checked)
            {
                c.Open();
                DataSet ds = new DataSet();
                string query = "select * from kits where Dept = @ab ";
                OleDbCommand cmd = new OleDbCommand(query, c);
                cmd.Parameters.Add("@ab", OleDbType.VarChar,255).Value = textBox1.Text.ToString();
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                /*ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.Fill(dt);*/
                dataGridView1.DataSource = dt.DefaultView;
                c.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
           c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kits", c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

       
    }
}
