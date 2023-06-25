using Apartman_Yonetim_Sistemi.Ekle;
using IslemKatmani;
using System;
using System.Data;
using System.Windows.Forms;

namespace Apartman_Yonetim_Sistemi 
{
    public partial class AidatGoruntule : Form
    {
        string filtre, daire;
        string id;
        DataTable dt;
        int en, boy;

        public AidatGoruntule()
        {
            InitializeComponent();
            en = this.Size.Width;
            boy = this.Size.Height;
            dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
            dgFiltre.DataSource = dt;
            if (dgFiltre.Rows[0].Cells[0].Value != null)
            {
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
                daire = dgFiltre.Rows[0].Cells[1].Value.ToString();
            }

        }

        private void dgFiltre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgFiltre.CurrentRow.Cells["Aidat Makbuz No"].Value.ToString();
            daire = dgFiltre.CurrentRow.Cells["Daire Numarası"].Value.ToString();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (!rbDaireNo.Checked && !rbTarih.Checked || txtFiltre.Text == "")
            {
                MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
                dgFiltre.DataSource = dt;
            }
            else
                dgFiltre.DataSource = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.Filtre("Aidat", filtre, aranan: textBox1.Text));
            dgFiltre.Update();
            rbTarih.Checked = true;
            rbTarih.Checked = false;
            txtFiltre.Clear();
        }

        private void btnDaireEkle_Click(object sender, EventArgs e)
        {
            AidatEkle ai = new AidatEkle();
            ai.ShowDialog();
            dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
            dgFiltre.DataSource = dt;
            dgFiltre.Update();
            if (dgFiltre.Rows[0].Cells[0].Value != null)
            {
                id = dgFiltre.Rows[0].Cells[0].Value.ToString();
                daire = dgFiltre.Rows[0].Cells[1].Value.ToString();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (id == null)
                MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
            else
            {
                AidatEkle ai = new AidatEkle(VeriIslemleri.BilgileriAl("Aidat", "AidatNo", id));
                ai.ShowDialog();
                dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
                dgFiltre.DataSource = dt;
                dgFiltre.Update();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (id == null)
                MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
            else
            {
                DialogResult cevap = MessageBox.Show(id + " Numaralı Makbuz Kaydı Silinecek. Silmek İstediğinize Emin Misiniz?", "Makbuz Silinecek", MessageBoxButtons.OKCancel);
                if (cevap.ToString() == "OK")
                    durum = VeriIslemleri.VeriSil("Aidat", "AidatNo", id);
            }
            if (durum)
            {
                MessageBox.Show("Silme işlemi başarılı!");
                dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
                dgFiltre.DataSource = dt;
                dgFiltre.Update();
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dgFiltre);

        private void btnToplamTutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(daire + " Nolu Dairenin Toplam Ödediği Aidat Tutarı\n-> " + VeriIslemleri.AidatToplamBul(daire) + "₺");

        }

        private void rbDaireNo_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void rbTarih_CheckedChanged(object sender, EventArgs e)
        {
            filtre = ((RadioButton)sender).Tag.ToString();
        }

        private void AidatGoruntule_Resize(object sender, EventArgs e)
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
