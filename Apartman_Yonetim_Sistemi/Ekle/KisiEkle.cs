using IslemKatmani;
using KayitKatmani;
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
    public partial class KisiEkle : Form, Ekle.IKontrol
    {
        bool gonderen;
        KisiKayitlari kk;
        public KisiEkle()
        {
            gonderen = false;
            InitializeComponent();
            kk = new KisiKayitlari();
            lblKisiEkle.Text = "Kişi Ekle";
            this.Text = "Kişi Ekle | Apartman Yönetim Sistemi";
        }

        public KisiEkle(string[] kayitlar)
        {
            gonderen = true;
            InitializeComponent();
            kk = new KisiKayitlari();
            kk.KisiID = Convert.ToInt32(kayitlar[0]);
            cbSahipSakin.Text = kayitlar[1];
            txtAd.Text = kayitlar[2];
            txtSoyad.Text = kayitlar[3];
            txtTelefon1.Text = kayitlar[4];
            txtTelefon2.Text = kayitlar[5];
            txtTelefon3.Text = kayitlar[6];
            txtEPosta.Text = kayitlar[7];
            txtIsAdres.Text = kayitlar[8];
            txtAciklama.Text = kayitlar[9];
            lblKisiEkle.Text = "Kişi Düzenle";
            this.Text = "Kişi Düzenle | Apartman Yönetim Sistemi";
        }

        public bool GirdiKontrol()
        {
            try
            {
                if (cbSahipSakin.Text != "" && txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon1.Text != "")
                {
                    kk.Durum = cbSahipSakin.Text;
                    kk.Ad = txtAd.Text;
                    kk.Soyad = txtSoyad.Text;
                    kk.TelefonNo1 = txtTelefon1.Text;
                    kk.TelefonNo2 = txtTelefon2.Text;
                    kk.TelefonNo3 = txtTelefon3.Text;
                    kk.Eposta = txtEPosta.Text;
                    kk.IsAdresi = txtIsAdres.Text;
                    kk.Aciklama = txtAciklama.Text;
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
                if (!gonderen)
                {
                    if (VeriIslemleri.KisiEkle(kk))
                    {
                        MessageBox.Show("Kişi Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
                else if (gonderen)
                {
                    if (VeriIslemleri.KisiDuzenle(kk))
                    {
                        MessageBox.Show("Kişi Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }
      }
   }
