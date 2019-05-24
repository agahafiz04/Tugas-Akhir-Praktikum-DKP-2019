using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Employee ID Cannot Be Empty");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Password Cannot Be Empty");
                }
                else
                {
                    if (textBox1.Text != "admin" && textBox2.Text != "12345")
                    {
                        MessageBox.Show("Your Login Failed");
                    }
                    else
                    {
                        MessageBox.Show("Succes Login");
                        Form1 Form1 = new Form1();
                        Form1.Show();
                        FormStack aga = new FormStack();
                        aga.Show();
                        this.Visible = false;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
