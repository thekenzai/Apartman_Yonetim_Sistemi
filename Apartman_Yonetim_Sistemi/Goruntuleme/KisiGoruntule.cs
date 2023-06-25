using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IslemKatmani;

namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    public partial class KisiGoruntule : Form
    {
        string filtre;
        string kisi;
        string id;
        int en, boy;
        DataTable dt;

        public KisiGoruntule()
        {
            InitializeComponent();
            en = this.Size.Width;
            boy = this.Size.Height;
            dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
            dgFiltre.DataSource = dt;
            if (dgFiltre.Rows[0].Cells[0].Value != null)
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (!rbSahipKiraci.Checked && !rbAd.Checked && !rbSoyad.Checked & !rbGirisTarihi.Checked && !rbCikisTarihi.Checked || txtFiltre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dgFiltre.DataSource = dt;
            }
            else
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.Filtre("Kisi", filtre, aranan: textBox1.Text));
            dgFiltre.Update();
            rbAd.Checked = true;
            rbAd.Checked = false;
            txtFiltre.Clear();
        }

        private void rbSahipKiraci_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbAd_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbSoyad_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbGirisTarihi_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbCikisTarihi_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
            else
            {
                string[] bilgiler = VeriIslemleri.BilgileriAl("Kisi", "KisiID", id);
                KisiEkle ke = new KisiEkle(bilgiler);
                ke.ShowDialog();
                dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
                dgFiltre.DataSource = dt;
                dgFiltre.Update();
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (kisi == null)
                MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
            else
            {
                DialogResult cevap = MessageBox.Show(kisi + " Silinecek. Silmek İstediğinize Emin Misiniz?", "Kişi Silinecek", MessageBoxButtons.OKCancel);
                if (cevap.ToString() == "OK")
                    durum = VeriIslemleri.VeriSil("Kisi", "KisiID", id);
            }
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
                dgFiltre.Update();
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dgFiltre);

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            KisiEkle ke = new KisiEkle();
            ke.ShowDialog();
            dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
            dgFiltre.DataSource = dt;
            dgFiltre.Update();
            try
            {
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
            }
            catch
            { }
        }

        private void KisiGoruntule_Resize(object sender, EventArgs e)
        {
            int boyfark = this.Size.Height - boy;
            int enfark = this.Size.Width - en;
            if (this.Size.Width > en || this.Size.Width < en)
            {
                dgFiltre.Width += enfark;
                en = this.Size.Width;
            }
            if (this.Size.Height > boy || this.Size.Height < boy)
            {
                dgFiltre.Height += boyfark;
                boy = this.Size.Height;
            }
        }
    }
}
