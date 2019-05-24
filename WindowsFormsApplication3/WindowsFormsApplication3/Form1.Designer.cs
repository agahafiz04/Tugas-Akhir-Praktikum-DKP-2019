namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A450 = new System.Windows.Forms.RadioButton();
            this.A900 = new System.Windows.Forms.RadioButton();
            this.A1300 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.Abodemen = new System.Windows.Forms.TextBox();
            this.BiayaKWH = new System.Windows.Forms.TextBox();
            this.JumlahHari = new System.Windows.Forms.TextBox();
            this.Tagihan = new System.Windows.Forms.TextBox();
            this.Pajak = new System.Windows.Forms.TextBox();
            this.Hitung = new System.Windows.Forms.Button();
            this.Keluar = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Cash = new System.Windows.Forms.TextBox();
            this.Kembali = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Subsidi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Kembalian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A450
            // 
            this.A450.AutoSize = true;
            this.A450.Location = new System.Drawing.Point(63, 91);
            this.A450.Name = "A450";
            this.A450.Size = new System.Drawing.Size(103, 17);
            this.A450.TabIndex = 0;
            this.A450.Text = "450 Volt Ampere";
            this.A450.UseVisualStyleBackColor = true;
            this.A450.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // A900
            // 
            this.A900.AutoSize = true;
            this.A900.Location = new System.Drawing.Point(63, 114);
            this.A900.Name = "A900";
            this.A900.Size = new System.Drawing.Size(103, 17);
            this.A900.TabIndex = 1;
            this.A900.Text = "900 Volt Ampere";
            this.A900.UseVisualStyleBackColor = true;
            this.A900.CheckedChanged += new System.EventHandler(this.A900_CheckedChanged);
            // 
            // A1300
            // 
            this.A1300.AutoSize = true;
            this.A1300.Location = new System.Drawing.Point(63, 137);
            this.A1300.Name = "A1300";
            this.A1300.Size = new System.Drawing.Size(109, 17);
            this.A1300.TabIndex = 2;
            this.A1300.Text = "1300 Volt Ampere";
            this.A1300.UseVisualStyleBackColor = true;
            this.A1300.CheckedChanged += new System.EventHandler(this.A1300_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pembayaran Rekening Listrik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kategori
            // 
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Items.AddRange(new object[] {
            "Subsidi",
            "Non-Subsidi"});
            this.Kategori.Location = new System.Drawing.Point(64, 50);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(121, 21);
            this.Kategori.TabIndex = 4;
            this.Kategori.Text = "Pilih";
            this.Kategori.SelectedIndexChanged += new System.EventHandler(this.Kategori_SelectedIndexChanged);
            // 
            // Abodemen
            // 
            this.Abodemen.Location = new System.Drawing.Point(84, 168);
            this.Abodemen.Name = "Abodemen";
            this.Abodemen.ReadOnly = true;
            this.Abodemen.Size = new System.Drawing.Size(100, 20);
            this.Abodemen.TabIndex = 7;
            // 
            // BiayaKWH
            // 
            this.BiayaKWH.Location = new System.Drawing.Point(301, 55);
            this.BiayaKWH.Name = "BiayaKWH";
            this.BiayaKWH.ReadOnly = true;
            this.BiayaKWH.Size = new System.Drawing.Size(101, 20);
            this.BiayaKWH.TabIndex = 8;
            // 
            // JumlahHari
            // 
            this.JumlahHari.Location = new System.Drawing.Point(301, 91);
            this.JumlahHari.Name = "JumlahHari";
            this.JumlahHari.Size = new System.Drawing.Size(101, 20);
            this.JumlahHari.TabIndex = 9;
            // 
            // Tagihan
            // 
            this.Tagihan.Location = new System.Drawing.Point(301, 119);
            this.Tagihan.Name = "Tagihan";
            this.Tagihan.ReadOnly = true;
            this.Tagihan.Size = new System.Drawing.Size(101, 20);
            this.Tagihan.TabIndex = 10;
            // 
            // Pajak
            // 
            this.Pajak.Location = new System.Drawing.Point(301, 147);
            this.Pajak.Name = "Pajak";
            this.Pajak.ReadOnly = true;
            this.Pajak.Size = new System.Drawing.Size(101, 20);
            this.Pajak.TabIndex = 11;
            // 
            // Hitung
            // 
            this.Hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hitung.Location = new System.Drawing.Point(48, 227);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(118, 39);
            this.Hitung.TabIndex = 12;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // Keluar
            // 
            this.Keluar.Location = new System.Drawing.Point(301, 314);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(100, 33);
            this.Keluar.TabIndex = 14;
            this.Keluar.Text = "Keluar";
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // Hapus
            // 
            this.Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hapus.Location = new System.Drawing.Point(48, 282);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(118, 39);
            this.Hapus.TabIndex = 15;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(302, 253);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(100, 20);
            this.Cash.TabIndex = 17;
            this.Cash.Text = "0";
            // 
            // Kembali
            // 
            this.Kembali.Location = new System.Drawing.Point(301, 279);
            this.Kembali.Name = "Kembali";
            this.Kembali.ReadOnly = true;
            this.Kembali.Size = new System.Drawing.Size(100, 20);
            this.Kembali.TabIndex = 18;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(301, 197);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(101, 20);
            this.Total.TabIndex = 19;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Uang Cash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Uang Kembali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Biaya Per-KWH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Jumlah Hari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tagihan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Pajak 10%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Abodemen";
            // 
            // Subsidi
            // 
            this.Subsidi.Location = new System.Drawing.Point(301, 171);
            this.Subsidi.Name = "Subsidi";
            this.Subsidi.ReadOnly = true;
            this.Subsidi.Size = new System.Drawing.Size(101, 20);
            this.Subsidi.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Subsidi";
            // 
            // Kembalian
            // 
            this.Kembalian.Location = new System.Drawing.Point(404, 253);
            this.Kembalian.Name = "Kembalian";
            this.Kembalian.Size = new System.Drawing.Size(20, 20);
            this.Kembalian.TabIndex = 31;
            this.Kembalian.Text = "...";
            this.Kembalian.UseVisualStyleBackColor = true;
            this.Kembalian.Click += new System.EventHandler(this.Kembalian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 372);
            this.Controls.Add(this.Kembalian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Subsidi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Kembali);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.Pajak);
            this.Controls.Add(this.Tagihan);
            this.Controls.Add(this.JumlahHari);
            this.Controls.Add(this.BiayaKWH);
            this.Controls.Add(this.Abodemen);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A1300);
            this.Controls.Add(this.A900);
            this.Controls.Add(this.A450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton A450;
        private System.Windows.Forms.RadioButton A900;
        private System.Windows.Forms.RadioButton A1300;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Kategori;
        private System.Windows.Forms.TextBox Abodemen;
        private System.Windows.Forms.TextBox BiayaKWH;
        private System.Windows.Forms.TextBox JumlahHari;
        private System.Windows.Forms.TextBox Tagihan;
        private System.Windows.Forms.TextBox Pajak;
        private System.Windows.Forms.Button Hitung;
        private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Cash;
        private System.Windows.Forms.TextBox Kembali;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Subsidi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Kembalian;
    }
}

