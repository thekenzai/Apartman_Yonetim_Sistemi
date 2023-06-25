using IslemKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    public partial class GiderleriGoruntule : Form
    {
        string filtre;
        string id;
        int en, boy;
        DataTable dt;

        public GiderleriGoruntule()
        {
            InitializeComponent();
            en = this.Size.Width;
            boy = this.Size.Height;
            dt = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
            dgFiltre.DataSource = dt;
            if (dgFiltre.Rows[0].Cells[0].Value != null)
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
        }

        private void dgFiltre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgFiltre.CurrentRow.Cells["Kayıt Numarası"].Value.ToString();
        }

        private void rbGiderTuru_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (!rbGiderTuru.Checked || txtFiltre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dgFiltre.DataSource = dt;
            }
            else
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.Filtre("Giderler", filtre, aranan: textBox1.Text));
            dgFiltre.Update();
            rbGiderTuru.Checked = true;
            rbGiderTuru.Checked = false;
            txtFiltre.Clear();
        }

        private void btnGiderDuzenle_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
            else
            {
                string[] bilgiler = VeriIslemleri.BilgileriAl("Giderler", "GiderID", id);
                Ekle.GiderEkle ge = new Ekle.GiderEkle(bilgiler);
                ge.ShowDialog();
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
                dgFiltre.Update();
            }
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (id == null)
                MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
            else
            {
                DialogResult cevap = MessageBox.Show(id + " Numaralı Kayıt Silinecek. Silmek İstediğinize Emin Misiniz?", "Kişi Silinecek", MessageBoxButtons.OKCancel);
                if (cevap.ToString() == "OK")
                    durum = VeriIslemleri.VeriSil("Giderler", "GiderID", id);
            }
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
                dgFiltre.Update();
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dgFiltre);

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            Ekle.GiderEkle ge = new Ekle.GiderEkle();
            ge.ShowDialog();
            dt = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
            dgFiltre.DataSource = dt;
            dgFiltre.Update();
            if (dgFiltre.Rows[0].Cells[0].Value != null)
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
        }

        private void GiderleriGoruntule_Resize(object sender, EventArgs e)
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
