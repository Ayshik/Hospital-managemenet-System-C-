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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User u = new User();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = da.Drdetailsall(u);
            dataGridView1.DataSource = dt;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == ""|| textBox2.Text == "" || textBox4.Text == ""|| textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("please check info");
            }
            else
            {

                     u.Star = comboBox3.Text;
                    u.UserId = label2.Text;
                    u.UserName = textBox2.Text;
                    u.Password = textBox3.Text;
                    u.Email = textBox4.Text;
                    u.PhoneNumber = textBox5.Text;
                    u.Password = textBox3.Text;
                    u.Status = comboBox1.Text;
                    u.Gender = comboBox2.Text;
                u.Catagory = textBox1.Text;
                    int w = da.Drupdate(u);
                    if (w > 0)
                    {
                        MessageBox.Show("Profile updated");
                    dt = da.Drdetailsall(u);
                    dataGridView1.DataSource = dt;
                }
                
            }
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.UserId = label2.Text;
            int i = da.Drrelease(u);
            if (i > 0)
            {
                MessageBox.Show("Deleted");

                dt = da.Drdetailsall(u);
                dataGridView1.DataSource = dt;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Visible = false;
            c.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;
                textBox1.Text = row.Cells["Catagory"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Password"].Value.ToString();
                label2.Text = row.Cells["Id"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                textBox5.Text = row.Cells["Phone"].Value.ToString();
                textBox6.Text = row.Cells["AssignDate"].Value.ToString();

                comboBox1.Text = row.Cells["Status"].Value.ToString();
                comboBox2.Text = row.Cells["Gender"].Value.ToString();





            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
