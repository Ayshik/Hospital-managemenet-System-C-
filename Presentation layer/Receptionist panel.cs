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
using Hospital_managemenet_System.Presentation_layer;



namespace Hospital_managemenet_System
{
    public partial class Receptionist_panel : Form
    {
        public Receptionist_panel()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User u = new User();
        Patient us = new Patient();
        private void button3_Click(object sender, EventArgs e)
        {
            dt = da.Drdetailsall(u);
            dataGridView1.DataSource = dt;
        }

        private void Receptionist_panel_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            us.UserId = label2.Text;
            int i = da.Patientdelete(us);
            if (i > 0)
            {
                MessageBox.Show("Released");

                dt = da.Patientinfo(us);
                dataGridView1.DataSource = dt;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 c = new Form12();
            this.Visible = false;
            c.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt = da.Patientdetails(us);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.Staffdetailsall(u);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientReg c = new PatientReg();
            this.Visible = false;
            c.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            row.ReadOnly = true;
            label2.Text = row.Cells["Id"].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = da.Patientinfo(us);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            this.Visible = false;
            c.Visible = true;
        }
    }
}
