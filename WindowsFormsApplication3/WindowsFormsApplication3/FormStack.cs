using System;
using System.Collections;
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
    public partial class FormStack : Form
    {
        public Stack a = new Stack();//deklarasi stack
        public Queue b = new Queue();//deklarasi queue
        public FormStack()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {//memulai statemen button 2 (HAPUS DATA)
                if (a.Count == 0 || b.Count == 0)//deklarasi fungsi 3
                {
                    MessageBox.Show("DATA KOSONG, TIDAK ADA YANG DIHAPUS");//output fungsi 3
                }
                else//deklarasi fungsi 4
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    string h_s = (string)a.Pop();
                    string h_q = (string)b.Dequeue();
                    foreach (string d in a)
                    {
                        textBox2.Text += d.ToString() + "\n";//output stack
                    }
                    foreach (string q in b)
                    {
                        textBox3.Text += q.ToString() + "\n";//output queue
                    }
                }
            }//akhir statemen button 2 (HAPUS DATA)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {//memulai statemen button 1 (TAMBAH DATA)
                if (a.Count > 12 || b.Count > 12)//deklarasi fungsi 1
                {
                    MessageBox.Show("DATA PENUH, HAPUS DATA DAHULU !!!");//output fungsi 1
                }
                else//deklarasi fungsi 2
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    a.Push(textBox1.Text.ToString());
                    b.Enqueue(textBox1.Text.ToString());
                    foreach (string d in a)
                    {
                        textBox2.Text += d.ToString() + "\n+";//output stack
                    }
                    foreach (string q in b)
                    {
                        textBox3.Text += q.ToString() + "\n+";//output queue
                    }
                    textBox1.Text = "";
                }
            }//akhir statemen button 1 (TAMBAH DATA)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }//akhir program
}
        