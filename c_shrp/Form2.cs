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
    public partial class Form2 : Form
    {
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Customer.accdb");
          OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\transaction.accdb");
         public int bill;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con1.Open();
            string q = "select name from Reff_List";
            OleDbDataAdapter da = new OleDbDataAdapter(q, con1);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBox2.Items.Add("--Select--");
            foreach (DataRow row in dt.Rows)
            {
                comboBox2.Items.Add(row["name"]);

            }
            comboBox2.SelectedIndex = 0;
            con1.Close();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
           
            con1.Open();
            String str = @"SELECT COUNT(ID) FROM pdetails ;";
            OleDbCommand comm2 = new OleDbCommand(str, con1);
            bill = Convert.ToInt32(comm2.ExecuteScalar());
            bill = bill + 1;
            id.Text = bill.ToString();
            con1.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGrid gd = new DataGrid();

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ptab();

            DataGridView gdo = new DataGridView();

               }
        void ptab()
        {
            
            string insertStatement = "INSERT INTO pdetails "
+ "([ID],[pname],[RefferBy],[sex],[phno],[bill],[pbill],[dbill],[date],[age]) "
              + "VALUES (@ID,@pname,@reff,@sex,@phno,@bill,@pbill,@dbill,@date,@age)";

            OleDbCommand insertCommand = new OleDbCommand(insertStatement, con1);
            insertCommand.Parameters.Add("@ID", OleDbType.VarChar, 255).Value = id.Text;
            insertCommand.Parameters.Add("@pname", OleDbType.VarChar, 255).Value = textBox1.Text;
            insertCommand.Parameters.Add("@reff", OleDbType.VarChar, 255).Value = comboBox2.SelectedItem.ToString();
            insertCommand.Parameters.Add("@sex", OleDbType.VarChar, 255).Value = comboBox1.SelectedItem.ToString();
            insertCommand.Parameters.Add("@phno", OleDbType.VarChar,10).Value = textBox2.Text;
            insertCommand.Parameters.Add("@bill", OleDbType.Currency).Value = Convert.ToDouble(textBox5.Text);
            insertCommand.Parameters.Add("@pbill", OleDbType.Currency).Value = Convert.ToDouble(textBox6.Text);
            insertCommand.Parameters.Add("@dbill", OleDbType.Currency).Value = Convert.ToDouble(textBox7.Text);
            insertCommand.Parameters.Add("@date", OleDbType.Date).Value = dateTimePicker1.Value.Date;
            insertCommand.Parameters.Add("@age", OleDbType.Numeric).Value = textBox3.Text;

            con1.Open();

            try
            {
                if (textBox2.TextLength == 10 )
                {
                    insertCommand.CommandText = insertStatement;
                    insertCommand.Connection = con1;
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Data stored", "success");
                }
                else
                {
                    MessageBox.Show("enter valid phonenumber", "ErrorBlinkStyle");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con1.Close();

            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if (x is TextBox)

                {
                    ((TextBox)x).Clear();

                }


                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
                       
        }      
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

            
        private void button5_Click_1(object sender, EventArgs e)
        {
             
            con.Open();
            String strq = @"DELETE * FROM Details;";
            OleDbCommand comm1 = new OleDbCommand(strq, con);
            comm1.ExecuteNonQuery();
            con.Close();
            for (int i = 0; i < entries.Rows.Count - 1; i++)
            {
                string StrQuery = @"INSERT INTO Details(Sno,[Investigation],bill) VALUES (" + entries.Rows[i].Cells[0].Value + ", @Investigation , " + entries.Rows[i].Cells[2].Value + ");";

                try
                {

                    using (OleDbCommand comm = new OleDbCommand(StrQuery, con))
                    {
                        con.Open();
                        comm.Parameters.Add("@Investigation", OleDbType.VarChar, 255).Value = entries.Rows[i].Cells[1].Value;
                        comm.ExecuteNonQuery();

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                con.Close();
                
            }
            con.Open();
            String str = @"SELECT SUM(Bill) FROM Details;";
            OleDbCommand comm2 = new OleDbCommand(str, con);
            bill = Convert.ToInt32(comm2.ExecuteScalar());
            textBox5.Text = bill.ToString();
            con.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            textBox7.Text = (bill - Convert.ToDouble(textBox6.Text)).ToString();
        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

           
     
     }
}
