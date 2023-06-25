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

namespace Apartman_Yonetim_Sistemi
{
    public partial class KullaniciSifreDegistir : Form
    {
        public KullaniciSifreDegistir()
        {
            InitializeComponent();
        }

        private bool GirdiKontrol()
        {
            int suanSifre = VeriIslemleri.SifreAl();
            if (suanSifre != Convert.ToInt32(txtGecerliSifre.Text) && txtYeniSifre.Text != txtSifreOnay.Text)
                MessageBox.Show("Hatalı Giriş Yaptınız! Lütfen Tekrar Deneyiniz.");
            else
                return true;
            return false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                VeriIslemleri.SifreDuzenle(Convert.ToInt32(txtYeniSifre.Text));
                MessageBox.Show("Şifre Güncelleme İşlemi Başarıyla Tamamlandı!");
                this.Close();
            }
        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                txtGecerliSifre.PasswordChar = '\0';
                txtYeniSifre.PasswordChar = '\0';
                txtSifreOnay.PasswordChar = '\0';
            }
            else
            {
                txtGecerliSifre.PasswordChar = '*';
                txtYeniSifre.PasswordChar = '*';
                txtSifreOnay.PasswordChar = '*';
            }
        }
    }
}
