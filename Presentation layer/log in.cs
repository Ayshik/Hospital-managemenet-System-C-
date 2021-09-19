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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User em = new User();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Boolean state = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("TextBox cannot be empty");
            }
            else
            {
                em.UserId = textBox1.Text;
                em.Password = textBox2.Text;



                {
                    if (state == false)
                    {
                        dt = da.LoginA(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Form3 c = new Form3();
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }


                {
                    if (state == false)
                    {
                        dt = da.LoginD(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Form2 i = new Form2(textBox1.Text);
                            this.Visible = false;
                            i.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }



                {
                    if (state == false)
                    {
                        dt = da.LoginR(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Receptionist_panel acc = new Receptionist_panel();
                            this.Visible = false;
                            acc.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                     if (state == false)
                {
                    MessageBox.Show("Invalid id or password");
                }




                }


                



            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
