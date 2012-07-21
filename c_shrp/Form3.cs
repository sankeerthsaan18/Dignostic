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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SANKEERTH\Documents\Visual Studio 2010\Projects\WindowsFormsApplication3\WindowsFormsApplication3\Customer.accdb");
        int bill;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Male");
            comboBox3.Items.Add("Female");
            comboBox2.Items.Add("0de45");
            comboBox6.Items.Add("cash");
            comboBox6.Items.Add("DD");
            comboBox6.Items.Add("check");
            con.Open();
            string q = "select name from Reff_List";
            OleDbDataAdapter da = new OleDbDataAdapter(q, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBox4.Items.Add("--Select--");
            foreach (DataRow row in dt.Rows)
            {
                comboBox4.Items.Add(row["name"]);

            }
            comboBox4.SelectedIndex = 0;
            con.Close();
            con.Open();
            String str = @"SELECT COUNT(RecieptNo) FROM RecieptsEntry ;";
            OleDbCommand comm2 = new OleDbCommand(str, con);
            bill = Convert.ToInt32(comm2.ExecuteScalar());
            bill = bill + 1;
            textBox9.Text = bill.ToString();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rest();
        }

        private void rest()
        {
            foreach (Control sayre in this.Controls)
            {
                if (sayre is TextBox)
                {
                    (sayre as TextBox).Clear();
                }
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {

            
           
            string insertStmt = "INSERT INTO RecieptsEntry "
+ "([RecieptNo],[MRNo],[Date],[Age],[sex],[Address],[ContactNo],[Refferal],[Consultant],[PayMode],[Amount],[Hospchgs],[Towards],[Type],[PName]) "
              + "VALUES (@RN,@MRN,@date,@age,@sex,@addr,@Contno,@Ref,@Const,@PM,@Amt,@HC,@Twds,@type,@pname)";

            OleDbCommand insertCommand = new OleDbCommand(insertStmt, con);
            insertCommand.Parameters.Add("@RN", OleDbType.VarChar, 255).Value = textBox9.Text;
            insertCommand.Parameters.Add("@MRN", OleDbType.VarChar, 255).Value = comboBox2.SelectedItem.ToString();
            insertCommand.Parameters.Add("@date", OleDbType.Date).Value = dateTimePicker1.Value;
            insertCommand.Parameters.Add("@age", OleDbType.Numeric).Value = Convert.ToInt32(textBox3.Text);
            insertCommand.Parameters.Add("@sex", OleDbType.VarChar, 255).Value = comboBox3.SelectedItem.ToString();
            insertCommand.Parameters.Add("@addr", OleDbType.VarChar, 255).Value = textBox4.Text;
            insertCommand.Parameters.Add("@Contno", OleDbType.VarChar,10).Value = textBox5.Text;
            insertCommand.Parameters.Add("@Ref", OleDbType.VarChar, 255).Value = comboBox4.SelectedItem.ToString();
            insertCommand.Parameters.Add("@Const", OleDbType.VarChar, 255).Value = textBox1.Text;
            insertCommand.Parameters.Add("@PM", OleDbType.VarChar, 255).Value = comboBox6.SelectedItem.ToString();
            insertCommand.Parameters.Add("@Amt", OleDbType.VarChar, 255).Value = textBox6.Text;
            insertCommand.Parameters.Add("@HC", OleDbType.VarChar, 255).Value = textBox7.Text;
            insertCommand.Parameters.Add("@Twds", OleDbType.VarChar, 255).Value = textBox10.Text;
           

            if(radioButton1.Checked)
            {
                insertCommand.Parameters.Add("@type", OleDbType.VarChar, 255).Value = radioButton1.Text.ToString();
            }
            else
            {
                insertCommand.Parameters.Add("@type", OleDbType.VarChar, 255).Value = radioButton2.Text.ToString();
            }
            insertCommand.Parameters.Add("@pname", OleDbType.VarChar, 255).Value = textBox2.Text;
            con.Open();

            try
            {
                 if (textBox2.TextLength == 10 )
                {
                insertCommand.CommandText = insertStmt;
                insertCommand.Connection = con;
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
                con.Close();

            }
        }
    
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       
        }

       
    }

