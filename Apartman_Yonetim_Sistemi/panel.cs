﻿using System;
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
    public partial class panel : Form
    {
        OleDbConnection con;
        string[] kayitlar;
        public panel()
        {
            InitializeComponent();
            con = BaglantiSinifi.Con;
            kayitlar = KayitAl();
        }
        private string[] KayitAl()
        {
            string[] kayit = new string[2];
            try
            {
                OleDbCommand com = new OleDbCommand("Select * From Admin", con);
                con.Open();
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    kayit[0] = dr[0].ToString();
                    kayit[1] = dr[1].ToString();
                }
                con.Close();
                return kayit;
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı Bağlantısı Sağlanamadığı için Program Başlatılamadı!\nLütfen Geliştirici ile iletişime Geçiniz");
                Hakkinda hk = new Hakkinda();
                hk.ShowDialog();
                this.Close();
            }
            return null;
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            AnaEkran ae = new AnaEkran();
            ae.Show();
            if (txtKAdi.Text.Equals(kayitlar[0]) && txtSifre.Text.Equals(kayitlar[1]))
            {
                this.Visible = false;
                ae.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!\nLütfen Tekrar Deneyiniz.");
        }
    }
}
