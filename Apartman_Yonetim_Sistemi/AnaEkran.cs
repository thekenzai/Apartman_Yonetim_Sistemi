using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IslemKatmani;

namespace Apartman_Yonetim_Sistemi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHkknda_Click(object sender, EventArgs e)
        {
            Hakkinda hk = new Hakkinda();
            toolStripStatusLabel1.Text = "Mehmet Salih ÇOBAN @ 2021 | Tüm Hakları Saklıdır!";
            hk.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda hk = new Hakkinda();
            toolStripStatusLabel1.Text = "Mehmet Salih ÇOBAN @ 2021 | Tüm Hakları Saklıdır!";
            hk.ShowDialog();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void btnDaireGrntle_Click(object sender, EventArgs e)
        {
            Goruntuleme.DaireGoruntule dg = new Goruntuleme.DaireGoruntule();
			toolStripStatusLabel1.Text = "Daire Kayıtları Görüntüleniyor";
			dg.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void btnKisiGrntle_Click(object sender, EventArgs e)
        {
            Goruntuleme.KisiGoruntule kg = new Goruntuleme.KisiGoruntule();
            toolStripStatusLabel1.Text = "Kişi Kayıtları Görüntüleniyor";
            kg.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void btnAidatGrntle_Click(object sender, EventArgs e)
        {
            Goruntuleme.AidatGoruntule ag = new Goruntuleme.AidatGoruntule();
            toolStripStatusLabel1.Text = "Aidat Kayıtları Görüntüleniyor";
            ag.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void btnAracGrntle_Click(object sender, EventArgs e)
        {
            Goruntuleme.AracGoruntule ag = new Goruntuleme.AracGoruntule();
            toolStripStatusLabel1.Text = "Araç Kayıtları Görüntüleniyor";
            ag.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void btnAptGdrleri_Click(object sender, EventArgs e)
        {
            Goruntuleme.GiderleriGoruntule gg = new Goruntuleme.GiderleriGoruntule();
            gg.ShowDialog();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            KullaniciSifreDegistir ksd = new KullaniciSifreDegistir();
            ksd.ShowDialog();
        }

        private void daireleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntuleme.DaireGoruntule dg = new Goruntuleme.DaireGoruntule();
            toolStripStatusLabel1.Text = "Daire Kayıtları Görüntüleniyor";
            dg.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void kişileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntuleme.KisiGoruntule kg = new Goruntuleme.KisiGoruntule();
            toolStripStatusLabel1.Text = "Kişi Kayıtları Görüntüleniyor";
            kg.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void araçlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntuleme.AracGoruntule ag = new Goruntuleme.AracGoruntule();
            toolStripStatusLabel1.Text = "Araç Kayıtları Görüntüleniyor";
            ag.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void aidatGirdileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntuleme.AidatGoruntule ag = new Goruntuleme.AidatGoruntule();
            toolStripStatusLabel1.Text = "Aidat Kayıtları Görüntüleniyor";
            ag.ShowDialog();
            toolStripStatusLabel1.Text = "Kullanıma Hazır";
        }

        private void giderleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goruntuleme.GiderleriGoruntule gg = new Goruntuleme.GiderleriGoruntule();
            toolStripStatusLabel1.Text = "Giderler Görüntüleniyor";
            gg.ShowDialog();
            toolStripStatusLabel1.Text= "Kullanıma Hazır";
        }
    }
}