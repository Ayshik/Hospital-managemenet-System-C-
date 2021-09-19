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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Patient u = new Patient();
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = da.Patientdetails(u);
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
