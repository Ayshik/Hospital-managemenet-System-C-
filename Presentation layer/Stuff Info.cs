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
    public partial class Stuff_Info : Form
    {
        public Stuff_Info()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User u = new User();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Catagory"].Value.ToString();
                textBox3.Text = row.Cells["Address"].Value.ToString();

                label2.Text = row.Cells["Phone"].Value.ToString();

                comboBox2.Text = row.Cells["Gender"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.PhoneNumber = label2.Text;
            int i = da.Staffdelete(u);
            if (i > 0)
            {
                MessageBox.Show("Deleted");

                dt = da.Staffdetailsall(u);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("please check info");
            }
            else
            {


               
                u.UserName = textBox1.Text;
                
                u.Address = textBox3.Text;
                u.PhoneNumber = label2.Text;
               
                
                u.Gender = comboBox2.Text;
                u.Catagory = textBox2.Text;
                int w = da.Staffupdate(u);
                if (w > 0)
                {
                    MessageBox.Show("Profile updated");
                    dt = da.Staffdetailsall(u);
                    dataGridView1.DataSource = dt;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = da.Staffdetailsall(u);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Visible = false;
            c.Visible = true;
        }
    }
}