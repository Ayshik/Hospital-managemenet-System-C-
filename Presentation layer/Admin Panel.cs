using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_managemenet_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f5 = new Form8();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f6 = new Form5();
            f6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 re = new Form6();
            re.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 rr = new Form1();
            rr.Visible = true;
            this.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form8 c = new Form8();
            this.Visible = false;
            c.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form10 rr = new Form10 ();
            rr.Visible = true;
            this.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            this.Visible = false;
            c.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 c = new Form5();
            this.Visible = false;
            c.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Stuff_Info c = new Stuff_Info();
            this.Visible = false;
            c.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form6 c = new Form6();
            this.Visible = false;
            c.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form7 c = new Form7();
            this.Visible = false;
            c.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Best_Doctors c = new Best_Doctors();
            this.Visible = false;
            c.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form9 c = new Form9();
            this.Visible = false;
            c.Visible = true;
        }
    }
}