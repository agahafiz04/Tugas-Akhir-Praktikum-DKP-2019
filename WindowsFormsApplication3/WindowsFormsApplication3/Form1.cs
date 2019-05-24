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
    public partial class Form1 : Form
    {
        int abodemen;
        int biaya;
        int hari;
        int tagihan;
        int pajak;
        int subsidi;
        int total;
        int cash;
        int kembali;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Kategori.SelectedIndex == 0)
            {
                hari = Convert.ToInt16(JumlahHari.Text);
                tagihan = biaya * (24 * hari);
                Tagihan.Text = Convert.ToString(tagihan);
                pajak = tagihan / 10;
                Pajak.Text = Convert.ToString(pajak);
                subsidi = 55000;
                Subsidi.Text = Convert.ToString(subsidi);
                total = tagihan + pajak + abodemen - subsidi;
                Total.Text = Convert.ToString(total);

            }
            else if (Kategori.SelectedIndex == 1)
            {
                hari = Convert.ToInt16(JumlahHari.Text);
                tagihan = biaya * (24 * hari);
                Tagihan.Text = Convert.ToString(tagihan);
                pajak = tagihan / 10;
                Pajak.Text = Convert.ToString(pajak);
                total = tagihan + pajak + abodemen;
                Total.Text = Convert.ToString(total);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            abodemen = 25000;
            Abodemen.Text = Convert.ToString(abodemen);
            biaya = 250;
            BiayaKWH.Text = Convert.ToString(biaya);

        }

        private void A900_CheckedChanged(object sender, EventArgs e)
        {
            abodemen = 35000;
            Abodemen.Text = Convert.ToString(abodemen);
            biaya = 350;
            BiayaKWH.Text = Convert.ToString(biaya);
        }

        private void A1300_CheckedChanged(object sender, EventArgs e)
        {
            abodemen = 45000;
            Abodemen.Text = Convert.ToString(abodemen);
            biaya = 450;
            BiayaKWH.Text = Convert.ToString(biaya);
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            Kategori.SelectedIndex = 0;
            Kategori.Text = "Pilih";
            Abodemen.Text = "";
            BiayaKWH.Text = "";
            JumlahHari.Text = "";
            Tagihan.Text = "";
            Pajak.Text = "";
            Subsidi.Text = "";
            Total.Text = "";
            Cash.Text = "0";
            Kembali.Text = "";
        }

        private void Kembalian_Click(object sender, EventArgs e)
        {
            cash = Convert.ToInt32(Cash.Text);
            kembali = cash - total;
            Kembali.Text = Convert.ToString(kembali);
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            DialogResult Choice;
            Choice = MessageBox.Show("Benarkah Anda Ingin Keluar  dari aplikasi ini ???", "Konfirmasi", MessageBoxButtons.YesNo);
            if (Choice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
