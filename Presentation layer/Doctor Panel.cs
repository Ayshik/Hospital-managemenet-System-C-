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
    public partial class Form2 : Form
    {
        public Form2(string uid)
        {
            InitializeComponent();
            label2.Text = uid;
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Patient u = new Patient();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            this.Visible = false;
            c.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.Drid = int.Parse(label2.Text);
            dt = da.DrAppointment(u);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Currentstatus i = new Currentstatus(label2.Text);
            this.Visible = false;
            i.Visible = true;
        }
    }
}
