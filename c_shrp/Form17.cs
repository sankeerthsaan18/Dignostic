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
    public partial class Form17 : Form
    {
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\kits_n_expenses.accdb");
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string StrQuery = @"INSERT INTO kits([Name],Price,[Dept],Quantity) VALUES (@Name," + dataGridView1.Rows[i].Cells[1].Value + ",@Dept," + dataGridView1.Rows[i].Cells[3].Value + ");";

                try
                {

                    using (OleDbCommand comm = new OleDbCommand(StrQuery, con))
                    {
                        con.Open();
                        comm.Parameters.Add("@Name", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[0].Value;
                        comm.Parameters.Add("@Dept", OleDbType.VarChar, 255).Value = dataGridView1.Rows[i].Cells[2].Value;
                        comm.ExecuteNonQuery();
                        MessageBox.Show("KitData stored", "success");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
