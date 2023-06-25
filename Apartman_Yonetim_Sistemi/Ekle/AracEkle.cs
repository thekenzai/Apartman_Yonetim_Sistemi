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
    public partial class AracEkle : Form, Ekle.IKontrol
    {
        bool gonderen;
        AracKayitlari ak;
        object[] daireler;
        public AracEkle()
        {
            gonderen = false;
            InitializeComponent();
            daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
            cbDaireNo.Items.AddRange(daireler);
            lblTasitlar.Text = "Taşıt Ekle";
            this.Text = "Taşıt Ekle | Apartman Yönetim Sistemi";
        }

        public AracEkle(string[] kayitlar)
        {
            gonderen = true;
            InitializeComponent();
            cbDaireNo.DropDownStyle = ComboBoxStyle.DropDown;
            txtAracPlaka.Enabled = false;
            cbDaireNo.Enabled = false;
            daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
            cbDaireNo.Items.AddRange(daireler);
            txtAracPlaka.Text = kayitlar[1];
            txtMarka.Text = kayitlar[2];
            txtModel.Text = kayitlar[3];
            cbDaireNo.Text = kayitlar[0];
            txtTelefonNo.Text = kayitlar[4];
            lblTasitlar.Text = "Taşıt Düzenle";
            this.Text = "Taşıt Düzenle | Apartman Yönetim Sistemi";
        }
        public bool GirdiKontrol()
        {
            try
            {
                ak = new AracKayitlari();
                if (txtAracPlaka.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && cbDaireNo.Text != "")
                {
                    ak.AracPlaka = txtAracPlaka.Text;
                    ak.Marka = txtMarka.Text;
                    ak.Model = txtModel.Text;
                    ak.DaireNo = Convert.ToInt32(cbDaireNo.Text);
                    ak.TelefonNo = txtTelefonNo.Text;
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
                    if (VeriIslemleri.AracEkle(ak))
                    {
                        MessageBox.Show("Araç Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Aynı Plakaya Sahip Araç Eklenemez!");
                }
                else if (gonderen)
                {
                    if (VeriIslemleri.AracDuzenle(ak))
                    {
                        MessageBox.Show("Araç Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
            }

            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }

        private void tb_plaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
