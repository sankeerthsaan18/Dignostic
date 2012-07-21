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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Customer.accdb");

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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from pdetails",c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void mm(object sender, MouseEventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from pdetails where sex like 'M%' ", c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

        private void mf(object sender, MouseEventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from pdetails where sex like 'F%'", c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

        /*  private void button3_Click(object sender, EventArgs e)
          {
              if (radioButton1.Checked)
              {
                  c.Open();
                  DataSet ds = new DataSet();
                  string query = "select * from pdetails where pname = @ab ";
                  OleDbCommand cmd = new OleDbCommand(query, c);
                  cmd.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
                  OleDbDataReader dr = cmd.ExecuteReader();
                  DataTable dt = new DataTable();
                  dt.Load(dr);
                  /*ds.Tables.Add(dt);
                  OleDbDataAdapter da = new OleDbDataAdapter();
                  da.Fill(dt);
                  dataGridView1.DataSource = dt.DefaultView;
                  c.Close();
              }
          }
          */
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
        
        }
        

       /* private void mp(object sender, KeyEventArgs e)
        {
            if (radioButton1.Checked)
            {
                c.Open();
                DataSet ds = new DataSet();
                string query = "select * from pdetails where pname = @ab ";
                OleDbCommand cmd = new OleDbCommand(query, c);
                cmd.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                /*ds.Tables.Add(dt);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.Fill(dt);*/
                /*dataGridView1.DataSource = dt.DefaultView;
                c.Close();
            }
        }*/

        private void ku(object sender, KeyEventArgs e)
        {
            if (radioButton1.Checked)
            {
                c.Open();
                DataSet ds = new DataSet();
                string query = "select * from pdetails where pname = @ab ";
                OleDbCommand cmd = new OleDbCommand(query, c);
                cmd.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
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

        private void radioButton3_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_3(object sender, EventArgs e)
        {

        }

        private void clk(object sender, EventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from pdetails", c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();

        }

              
    }
}
