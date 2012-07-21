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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

              private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form5 v3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (v3 == null || v3.IsDisposed)
            {
                v3 = new Form5();
                v3.Show();
            }
        }
        Form6 v4;
        private void button2_Click(object sender, EventArgs e)
        {
            if (v4 == null || v4.IsDisposed)
            {
                v4 = new Form6();
                v4.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form7 v5;

        private void button4_Click(object sender, EventArgs e)
        {
            if (v5 == null || v5.IsDisposed)
            {
                v5 = new Form7();
                v5.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
