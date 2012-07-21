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
    public partial class Form5 : Form
    {
        public Double bill;
        OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Customer.accdb");
        public Form5()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lc(object sender, MouseEventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            string query = "select ID,pname,bill,pbill from pdetails where date=@bc ";
            OleDbCommand cmd = new OleDbCommand(query, c);
            cmd.Parameters.Add("@bc", OleDbType.Date).Value = dateTimePicker1.Value.Date;
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            /*ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.Fill(dt);*/
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
            try
            {
                c.Open();
                String str = @"SELECT SUM(pbill) FROM pdetails WHERE date=@bb;";

                OleDbCommand comm2 = new OleDbCommand(str, c);
                comm2.Parameters.Add("@bb", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                bill = Convert.ToDouble(comm2.ExecuteScalar());

                label3.Text = bill.ToString() + "/-";
            }
            catch(Exception ex)
            {
                MessageBox.Show("selected date miss match");
                c.Close();
            }
                c.Close();
          }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ld(object sender, MouseEventArgs e)
        {
            c.Open();
            DataSet ds = new DataSet();
            string query = "select ID,pname,bill,dbill from pdetails where date=@bc ";
            OleDbCommand cmd = new OleDbCommand(query, c);
            cmd.Parameters.Add("@bc", OleDbType.Date).Value = dateTimePicker1.Value.Date;
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            /*ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.Fill(dt);*/
            dataGridView1.DataSource = dt.DefaultView;
            c.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
