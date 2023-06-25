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
    public partial class AidatEkle : Form, Ekle.IKontrol
    {
        bool gonderen;
        object[] daireler;
        AidatKayitlari ak;
        public AidatEkle()
        {
            gonderen = false;
            InitializeComponent();
            daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
            cbDaireNo.Items.AddRange(daireler);
            this.Text = "Aidat Girdisi Ekle | Apartman Yönetim Sistemi";
            lblAidatGirdi.Text = "Aidat Girdisi Ekle";
        }
        public AidatEkle(string[] kayitlar)
        {
            gonderen = true;
            InitializeComponent();
            cbDaireNo.DropDownStyle = ComboBoxStyle.DropDown;
            daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
            cbDaireNo.Items.AddRange(daireler);
            txtAidatNo.Text = kayitlar[0];
            cbDaireNo.Text = kayitlar[1];
            dtpTarih.Text = kayitlar[2];
            txtAidatUcret.Text = kayitlar[3];
            txtDemirbas.Text = kayitlar[4];
            txtToplam.Text = kayitlar[5];
            cbDaireNo.Enabled = false;
            lblAidatGirdi.Text = "Aidat Girdisi Düzenle";
            this.Text = "Aidat Girdisi Düzenle | Apartman Yönetim Sistemi";
        }

        public bool GirdiKontrol()
        {
            try
            {
                ak = new AidatKayitlari();
                if (txtAidatNo.Text != "" && cbDaireNo.Text != "" && txtAidatUcret.Text != "")
                {
                    ak.AidatNo = Convert.ToInt32(txtAidatNo.Text);
                    ak.DaireNo = Convert.ToInt32(cbDaireNo.Text);
                    ak.Tarih = dtpTarih.Value.ToString();
                    ak.AidatTutar = Convert.ToInt32(txtAidatUcret.Text);
                    ak.Demirbas = Convert.ToInt32(txtDemirbas.Text);
                    ak.ToplamTutar = Convert.ToInt32(txtToplam.Text);
                    return true;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return false;
        }

        private void AidatEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                if (!gonderen)
                {
                    if (VeriIslemleri.AidatEkle(ak))
                    {
                        MessageBox.Show("Aidat Girdisi Ekleme İşlemi Başarılı!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Aynı Makbuz Numarasına Sahip Girdi Ekleyemezsiniz!");
                }
                else if (gonderen)
                {
                    if (VeriIslemleri.AidatDuzenle(ak))
                    {
                        MessageBox.Show("Aidat Girdisi Düzenleme İşlemi Başarılı!");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
        }

        private void txtAidatUcret_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(txtAidatUcret.Text) + Convert.ToInt32(txtDemirbas.Text);
                txtToplam.Text = toplam.ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void txtDemirbas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(txtAidatUcret.Text) + Convert.ToInt32(txtDemirbas.Text);
                txtToplam.Text = toplam.ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
