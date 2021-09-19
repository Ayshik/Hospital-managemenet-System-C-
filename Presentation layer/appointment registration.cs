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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Patient u = new Patient();
            User us = new User();
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the information");
            }

           
            else
            { 



                u.UserName = textBox1.Text;


                u.UserId = textBox2.Text;
                u.PhoneNumber = textBox3.Text;
                u.Age = textBox5.Text;
                u.Drid = int.Parse(textBox6.Text);
                u.Drfees = textBox4.Text;
                us.drid= textBox6.Text;
                dt = da.DrTP(us);
                if (dt.Rows.Count == 1)
                {
                    label8.Text = dt.Rows[0][0].ToString();
                }
             

                int i = da.Createpatient(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Created");
                }
            }

            var plus = (Convert.ToInt16(label8.Text) + Convert.ToInt16(1)).ToString();
            us.drid = textBox6.Text;
            
            us.tp = plus;
            int w = da.TPupdate(us);
            if (w > 0)
            {
                MessageBox.Show("TP updated");
               
            }
            else { MessageBox.Show("Invalid  Doctor Id"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist_panel c = new Receptionist_panel();
            this.Visible = false;
            c.Visible = true;
        }
    }
}