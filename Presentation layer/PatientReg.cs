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
namespace Hospital_managemenet_System.Presentation_layer
{
    public partial class PatientReg : Form
    {
        public PatientReg()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Patient u = new Patient();

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist_panel c = new Receptionist_panel();
            this.Visible = false;
            c.Visible = true;
        }

        private void PatientReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                u.UserName = textBox1.Text;


                u.UserId = textBox2.Text;
                u.PhoneNumber = textBox3.Text;

                u.Age = textBox5.Text;
                u.gender = comboBox1.Text;
                u.Room = textBox6.Text;


                int i = da.patientReg(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}