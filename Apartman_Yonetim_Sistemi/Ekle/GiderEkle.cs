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

namespace Apartman_Yonetim_Sistemi.Ekle
{
    public partial class GiderEkle : Form
    {
        bool gonderen;
        KayitKatmani.GiderKayitlari gk;

        public GiderEkle()
        {
            gonderen = false;
            InitializeComponent(); gk = new KayitKatmani.GiderKayitlari();
            lblGiderler.Text = "Gider Ekle";
            this.Text = "Gider Ekle | Apartman Yönetim Sistemi";
        }
        public GiderEkle(string[] kayitlar)
        {
            gonderen = true;
            InitializeComponent();
            gk = new KayitKatmani.GiderKayitlari();
            gk.GiderID = Convert.ToInt32(kayitlar[0]);
            txtGiderTuru.Text = kayitlar[1];
            txtTutar.Text = kayitlar[2];
            dtpTarih.Text = kayitlar[3];
            txtAciklama.Text = kayitlar[4];
            lblGiderler.Text = "Gider Düzenle";
            this.Text = "Gider Düzenle | Apartman Yönetim Sistemi";
        }

        public bool GirdiKontrol()
        {
            try
            {
                if (txtGiderTuru.Text != "" && txtTutar.Text != "")
                {
                    gk.GiderTuru = txtGiderTuru.Text;
                    gk.Tutar = Convert.ToInt32(txtTutar.Text);
                    gk.Tarih = dtpTarih.Value.ToString();
                    gk.Aciklama = txtAciklama.Text;
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                if (!gonderen)
                {
                    if (VeriIslemleri.GiderEkle(gk))
                    {
                        MessageBox.Show("Gider Girdisi Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
                else if (gonderen)
                {
                    if (VeriIslemleri.GiderDuzenle(gk))
                    {
                        MessageBox.Show("Gider Girdisi Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }
    }
}
