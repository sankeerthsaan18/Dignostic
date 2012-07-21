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
    public partial class Form19 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\kits_n_expenses.accdb");
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string StrQuery = @"INSERT INTO Expenses([Voucher],[Towards],Amount,[Purpose],[PayType],[Date_Exp]) VALUES (@Voucher,@Towards," + dataGridView1.Rows[i].Cells[2].Value + ",@Purpose,@PayType,@Date_Exp);";

                    try
                    {

                        using (OleDbCommand comm = new OleDbCommand(StrQuery, con))
                        {
                            con.Open();
                            comm.Parameters.Add("@Voucher", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[0].Value;
                            comm.Parameters.Add("@Towards", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[1].Value;
                            comm.Parameters.Add("@Purpose", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[3].Value;
                            comm.Parameters.Add("@PayType", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            comm.Parameters.Add("@Date_Exp", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Data stored", "success");

                        }

                    }
                    catch (Exception )
                    {
                        MessageBox.Show("You have already entered the above data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                    con.Close();
                }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
