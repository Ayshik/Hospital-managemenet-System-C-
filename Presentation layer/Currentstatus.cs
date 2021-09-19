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
    public partial class Currentstatus : Form
    {
        public Currentstatus(string uid)
        {
            InitializeComponent();
            label10.Text = uid;
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        User odc = new User();
        private void Currentstatus_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 i = new Form2(label10.Text);
            this.Visible = false;
            i.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Active")
            {
                MessageBox.Show("You Are Allready Active ");
            }
            else
            {
                odc.UserId = label10.Text;


                int w = da.Dractive(odc);
                if (w > 0)
                {
                    MessageBox.Show("Thanks for coming back");

                    dt = da.Drfetch(odc);

                    if (dt.Rows.Count == 1)
                    {


                        label6.Text = dt.Rows[0][8].ToString();



                    }



                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Inactive")
            {
                MessageBox.Show("You Are Allready Inactive ");
            }
            else
            {
                odc.UserId = label10.Text;


                int w = da.Drinactive(odc);
                if (w > 0)
                {
                    MessageBox.Show("Thanks for your service");

                    dt = da.Drfetch(odc);

                    if (dt.Rows.Count == 1)
                    {


                        label6.Text = dt.Rows[0][8].ToString();

                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}