﻿using IslemKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yonetim_Sistemi
{
    public partial class AracGoruntule : Form
    {
        string filtre;
        string plaka;
        DataTable dt;
        int en, boy;

        public AracGoruntule()
        {
            InitializeComponent();
            en = this.Size.Width;
            boy = this.Size.Height;
            dt = VeriIslemleri.TabloDoldur("Arac", VeriIslemleri.BilgileriGetir("Arac", "AracPlaka"));
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows[0].Cells[1].Value != null)
                plaka = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }

        private void rbPlaka_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbMarka_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbModel_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plaka = dataGridView1.CurrentRow.Cells["Araç Plaka"].Value.ToString();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle ae = new AracEkle();
            ae.ShowDialog();
            dt = VeriIslemleri.TabloDoldur("Arac", VeriIslemleri.BilgileriGetir("Arac", "AracPlaka"));
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            if (dataGridView1.Rows[0].Cells[0].Value != null)
                plaka = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }

        private void btnAracDuzenle_Click(object sender, EventArgs e)
        {
            if (plaka == null)
                MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
            else
            {
                AracEkle ae = new AracEkle(VeriIslemleri.BilgileriAl("Arac", "AracPlaka", plaka));
                ae.ShowDialog();
                dt = VeriIslemleri.TabloDoldur("Arac", VeriIslemleri.BilgileriGetir("Arac", "AracPlaka"));
                dataGridView1.DataSource = dt;
                dataGridView1.Update();
            }
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (plaka == null)
                MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
            else
            {
                DialogResult cevap = MessageBox.Show(plaka + " Plakalı Araç Silinecek. Silmek İstediğinize Emin Misiniz?", "Araç Silinecek", MessageBoxButtons.OKCancel);
                if (cevap.ToString() == "OK")
                    durum = VeriIslemleri.AracSil(plaka);
            }
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dt = VeriIslemleri.TabloDoldur("Arac", VeriIslemleri.BilgileriGetir("Arac", "AracPlaka"));
                dataGridView1.DataSource = dt;
                dataGridView1.Update();
            }
        }

        private void btnRapor_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dataGridView1);

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            if (!rbPlaka.Checked && !rbMarka.Checked && !rbModel.Checked || txtFiltre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dataGridView1.DataSource = dt;
            }
            else
                dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Arac", VeriIslemleri.Filtre("Arac", filtre, aranan: textBox1.Text));
            dataGridView1.Update();
            rbPlaka.Checked = true;
            rbPlaka.Checked = false;
            txtFiltre.Clear();
        }

        private void AracGoruntule_Resize(object sender, EventArgs e)
        {
            int boyfark = this.Size.Height - boy;
            int enfark = this.Size.Width - en;
            if (this.Size.Width > en || this.Size.Width < en)
            {
                dataGridView1.Width += enfark;
                en = this.Size.Width;
            }
            if (this.Size.Height > boy || this.Size.Height < boy)
            {
                dataGridView1.Height += boyfark;
                boy = this.Size.Height;
            }
        }
    }
}
