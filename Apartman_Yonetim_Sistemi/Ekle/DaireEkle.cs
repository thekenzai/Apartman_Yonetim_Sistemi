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
    public partial class DaireEkle : Form, Ekle.IKontrol
    {
        bool gonderen;
        DaireKayitlari dk;
        string daireSahibi, daireSakini;
        public DaireEkle()
        {
            gonderen = false;
            InitializeComponent();
            cbDaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
            cbDaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
            lblDaireler.Text = "Daire Ekle";
            this.Text = "Daire Ekle | Apartman Yönetim Sistemi";
        }

        public DaireEkle(string[] kayitlar)
        {
            gonderen = true;
            InitializeComponent();
            cbDaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
            cbDaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
            txtDaireNo.Text = kayitlar[0];
            cbDaireDurum.Text = kayitlar[1];
            cbDaireSahibi.Text = kayitlar[2];
            daireSahibi = kayitlar[2];
            cbDaireSakini.Text = kayitlar[3];
            daireSakini = kayitlar[3];
            nudKat.Text = kayitlar[4];
            txtDaireNo.Enabled = false;
            lblDaireler.Text = "Daire Düzenle";
            this.Text = "Daire Düzenle | Apartman Yönetim Sistemi";
        }
        public bool GirdiKontrol()
        {
            try
            {
                dk = new DaireKayitlari();
                if (txtDaireNo.Text != "" && cbDaireDurum.Text != "" && cbDaireSahibi.Text != "" && cbDaireSakini.Text != "")
                {
                    dk.DaireNo = Convert.ToInt32(txtDaireNo.Text);
                    dk.DaireDurum = cbDaireDurum.Text;
                    dk.DaireSahibi = cbDaireSahibi.Text;
                    dk.DaireSakini = cbDaireSakini.Text;
                    dk.Kat = Convert.ToInt32(nudKat.Value);
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
                    if (VeriIslemleri.DaireEkle(dk))
                    {
                        MessageBox.Show("Daire Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Aynı numaraya sahip daire ekleyemezsiniz!");
                }
                else if (gonderen)
                {
                    if (VeriIslemleri.DaireDuzenle(dk))
                    {
                        MessageBox.Show("Daire Düzenleme İşlemi Başarılı!");
                        EskiDaireEkle ede = new EskiDaireEkle(daireNo: dk.DaireNo.ToString(), daireSahibi: daireSahibi, daireSakini: daireSakini);
                        ede.ShowDialog();
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
