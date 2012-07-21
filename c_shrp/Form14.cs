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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Customer.accdb");
        private void Form14_Load(object sender, EventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from RecieptsEntry", c);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton4.Checked)
            {
       
                c.Open();
                DataSet ds1 = new DataSet();
                string query = "select * from RecieptsEntry where MRNo = @ab ";
                OleDbCommand cmd1 = new OleDbCommand(query, c);
                cmd1.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);

                dataGridView1.DataSource = dt1.DefaultView;
                c.Close();
            }
            else if (radioButton1.Checked)
            {
           
                c.Open();
                DataSet ds2 = new DataSet();
                string query = "select * from RecieptsEntry where PName  = @ab ";
                OleDbCommand cmd2 = new OleDbCommand(query, c);
                cmd2.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);

                dataGridView1.DataSource = dt2.DefaultView;
                c.Close();
            }
            else if (radioButton5.Checked)
            {
                
                c.Open();
               
                string query = "select * from RecieptsEntry where ContactNo = @ab ";
                OleDbCommand cmd3 = new OleDbCommand(query, c);
                cmd3.Parameters.Add("@ab", OleDbType.VarChar).Value = textBox1.Text.ToString();
                OleDbDataReader dr3 = cmd3.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(dr3);

                dataGridView1.DataSource = dt3.DefaultView;
                c.Close();
            }
            
        }

       

    }
}
