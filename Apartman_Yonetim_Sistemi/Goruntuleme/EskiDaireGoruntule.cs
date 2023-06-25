using IslemKatmani;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop;

namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    public partial class EskiDaireGoruntule : Form
    {
        string filtre;
        string kayitID;
        DataTable dt;
        int en, boy;

        public EskiDaireGoruntule()
        {
            InitializeComponent();
            en = this.Size.Width;
            boy = this.Size.Height;
            dt = VeriIslemleri.TabloDoldur("EskiDaire", VeriIslemleri.BilgileriGetir("EskiDaire", "DaireNo"));
            dgFiltre.DataSource = dt;
            if (dgFiltre.Rows[0].Cells[0].Value != null)
                kayitID = dgFiltre.Rows[0].Cells[0].Value.ToString();
        }

        private void rbDaireDurum_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbDaireSahibi_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbDaireSakini_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (!rbDaireDurum.Checked && !rbDaireSahibi.Checked && !rbDaireSakini.Checked || txtFiltre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dgFiltre.DataSource = dt;
            }
            else
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("EskiDaire", VeriIslemleri.Filtre("EskiDaire", filtre, aranan: textBox1.Text));
            dgFiltre.Update();
            rbDaireDurum.Checked = true;
            rbDaireDurum.Checked = false;
            txtFiltre.Clear();
        }

        private void btnDaireEkle_Click(object sender, EventArgs e)
        {
            EskiDaireEkle de = new EskiDaireEkle();
            de.ShowDialog();
            dt = VeriIslemleri.TabloDoldur("EskiDaire", VeriIslemleri.BilgileriGetir("EskiDaire", "DaireNo"));
            dgFiltre.DataSource = dt;
            dgFiltre.Update();
            if (dgFiltre.Rows[0].Cells[0].Value != null)
                kayitID = dgFiltre.Rows[0].Cells[0].Value.ToString();
        }

        private void btnDaireDuzenle_Click(object sender, EventArgs e)
        {
            if (kayitID == null)
                MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
            else
            {
                EskiDaireEkle de = new EskiDaireEkle(VeriIslemleri.BilgileriAl("EskiDaire", "KayitID", kayitID));
                de.ShowDialog();
                dt = VeriIslemleri.TabloDoldur("EskiDaire", VeriIslemleri.BilgileriGetir("EskiDaire", "DaireNo"));
                dgFiltre.DataSource = dt;
                dgFiltre.Update();
            }
        }

        private void btnDaireSil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (kayitID == null)
                MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
            else
            {
                DialogResult cevap = MessageBox.Show(kayitID + " Numaralı Daire Silinecek. Silmek İstediğinize Emin Misiniz?", "Daire Silinecek", MessageBoxButtons.OKCancel);
                if (cevap.ToString() == "OK")
                    durum = VeriIslemleri.VeriSil("EskiDaire", "DaireNo", kayitID);
            }
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dt = VeriIslemleri.TabloDoldur("EskiDaire", VeriIslemleri.BilgileriGetir("EskiDaire", "DaireNo"));
                dgFiltre.DataSource = dt;
                dgFiltre.Update();
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dgFiltre);

        private void dgFiltre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kayitID = dgFiltre.CurrentRow.Cells["Kayıt Numarası"].Value.ToString();
        }

        private void DaireGoruntule_Resize(object sender, EventArgs e)
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