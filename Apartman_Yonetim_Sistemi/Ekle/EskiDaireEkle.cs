using IslemKatmani;
using KayitKatmani;
using System;
using System.Windows.Forms;

namespace Apartman_Yonetim_Sistemi.Ekle
{
    public partial class EskiDaireEkle : Form, Ekle.IKontrol
    {
        byte gonderen;
        EskiDaireKayitlari dk;
        public EskiDaireEkle()
        {
            dk = new EskiDaireKayitlari();
            gonderen = 0;
            InitializeComponent();
            cbDaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
            cbDaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
            lblEskiDaireler.Text = "Eski Daire Kaydı Ekle";
            this.Text = "Eski Daire Kaydı Ekle | Apartman Yönetim Sistemi";
        }
        public EskiDaireEkle(string[] kayitlar)
        {
            dk = new EskiDaireKayitlari();
            gonderen = 1;
            InitializeComponent();
            cbDaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
            cbDaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
            txtDaireNo.Enabled = false;
            dk.KayitID = Convert.ToInt32(kayitlar[0]);
            txtDaireNo.Text = kayitlar[1];
            cbDaireSahibi.Text = kayitlar[2];
            cbDaireSakini.Text = kayitlar[3];
            dtpGirisTarih.Text = kayitlar[4];
            dtpCikisTarihi.Text = kayitlar[5];
            txtAciklama.Text = kayitlar[6];
            lblEskiDaireler.Text = "Eski Daire Kaydı Düzenle";
            this.Text = "Eski Daire Kaydı Düzenle | Apartman Yönetim Sistemi";
        }
        public EskiDaireEkle(string daireNo, string daireSahibi, string daireSakini)
        {
            dk = new EskiDaireKayitlari();
            gonderen = 2;
            InitializeComponent();
            cbDaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
            cbDaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
            txtDaireNo.Text = daireNo;
            cbDaireSahibi.Text = daireSahibi;
            cbDaireSakini.Text = daireSakini;
            lblEskiDaireler.Text = "Eski Daire Kaydı Ekle";
            this.Text = "Eski Daire Kaydı Ekle | Apartman Yönetim Sistemi";
        }
        public bool GirdiKontrol()
        {
            try
            {
                if (txtDaireNo.Text != "" && cbDaireSahibi.Text != "" && cbDaireSakini.Text != "")
                {
                    dk.DaireNo = Convert.ToInt32(txtDaireNo.Text);
                    dk.DaireSahibi = cbDaireSahibi.Text;
                    dk.DaireSakini = cbDaireSakini.Text;
                    dk.GirisTarihi = dtpGirisTarih.Value.ToShortDateString();
                    dk.CikisTarihi = dtpCikisTarihi.Value.ToShortDateString();
                    dk.Aciklama = txtAciklama.Text;
                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                if (gonderen == 0 || gonderen == 2)
                {
                    if (VeriIslemleri.EskiDaireEkle(dk))
                    {
                        MessageBox.Show("Eski Daire Kaydı Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Aynı numaraya sahip daire ekleyemezsiniz!");
                }
                else if (gonderen == 1)
                {
                    if (VeriIslemleri.EskiDaireDuzenle(dk))
                    {
                        MessageBox.Show("Eski Daire Kaydı Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Düzenleme işlemi gerçekleştirilemedi!\nLütfen değerleri kontrol ediniz.");
                }
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }
    }
}
