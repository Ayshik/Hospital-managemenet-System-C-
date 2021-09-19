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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User u = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                u.UserName = textBox1.Text;
                u.Password = textBox5.Text;

                u.Address = textBox4.Text;
                u.PhoneNumber = textBox3.Text;

                u.Email = textBox2.Text;
                u.Gender = comboBox1.Text;

                int i = da.CreateAccountrecep(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                dt = da.Resepuid(u);
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

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Visible = false;
            c.Visible = true;
        }
    }
}
    