using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_managemenet_System.DataAccess_layer;
using Hospital_managemenet_System.Business_logic_layer;

namespace Hospital_managemenet_System
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User u = new User();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || textBox5.Text == ""||textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                u.UserName = textBox1.Text;


                u.Email = textBox2.Text;
                u.PhoneNumber = textBox3.Text;
                u.Password = textBox5.Text;
                u.Catagory = textBox4.Text;
                u.Gender = comboBox1.Text;

                int i = da.CreateAccountdoc(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                dt = da.Drid(u);
                if (dt.Rows.Count == 1)
                {
                    label7.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Error in acc num");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Visible = false;
            c.Visible = true;
        }
    }
}
