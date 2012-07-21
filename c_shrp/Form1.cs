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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 v;
        Form4 v2;
       private void button1_Click(object sender, EventArgs e)
        {

            if (v == null || v.IsDisposed)
            {
                v = new Form2();
                v.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (v2 == null || v2.IsDisposed)
            {
                v2 = new Form4();
                v2.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form3 v1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (v1 == null || v1.IsDisposed)
            {
                v1 = new Form3();
                v1.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form8 v6;
        private void button4_Click(object sender, EventArgs e)
        {
            if (v6 == null || v6.IsDisposed)
            {
                v6 = new Form8();
                v6.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        Form9 v7;
        private void button7_Click(object sender, EventArgs e)
        {
            if (v7 == null || v7.IsDisposed)
            {
                v7 = new Form9();
                v7.Show();
            }
        }
        Form10 v8;
        private void button8_Click(object sender, EventArgs e)
        {
            if (v8 == null || v8.IsDisposed)
            {
                v8 = new Form10();
                v8.Show();
            }
        }
        Form11 v9;
        private void button9_Click(object sender, EventArgs e)
        {
            if (v9 == null || v9.IsDisposed)
            {
                v9 = new Form11();
                v9.Show();
            }
        }
        Form12 v10;
        private void button11_Click(object sender, EventArgs e)
        {
            if (v10 == null || v10.IsDisposed)
            {
                v10 = new Form12();
                v10.Show();
            }
        }
        Form16 v13;
        private void button5_Click(object sender, EventArgs e)
        {
            if (v13 == null || v13.IsDisposed)
            {
                v13 = new Form16();
                v13.Show();
            }
        }
        Form18 v16;
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (v16 == null || v16.IsDisposed)
            {
                v16 = new Form18();
                v16.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
