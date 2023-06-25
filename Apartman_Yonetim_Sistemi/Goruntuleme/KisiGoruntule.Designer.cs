namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    partial class KisiGoruntule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiGoruntule));
            this.dgFiltre = new System.Windows.Forms.DataGridView();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.gbFiltrele = new System.Windows.Forms.GroupBox();
            this.rbCikisTarihi = new System.Windows.Forms.RadioButton();
            this.rbGirisTarihi = new System.Windows.Forms.RadioButton();
            this.rbSoyad = new System.Windows.Forms.RadioButton();
            this.rbAd = new System.Windows.Forms.RadioButton();
            this.rbSahipKiraci = new System.Windows.Forms.RadioButton();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.btnKisiSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKisiDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKisiEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblKisiler = new DevExpress.XtraEditors.LabelControl();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltre)).BeginInit();
            this.gbFiltrele.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiltre
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiltre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltre.Location = new System.Drawing.Point(175, -5);
            this.dgFiltre.MultiSelect = false;
            this.dgFiltre.Name = "dgFiltre";
            this.dgFiltre.ReadOnly = true;
            this.dgFiltre.Size = new System.Drawing.Size(704, 503);
            this.dgFiltre.TabIndex = 10;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Appearance.Options.UseFont = true;
            this.btnFiltrele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltrele.ImageOptions.SvgImage")));
            this.btnFiltrele.Location = new System.Drawing.Point(6, 226);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(143, 32);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // gbFiltrele
            // 
            this.gbFiltrele.Controls.Add(this.txtFiltre);
            this.gbFiltrele.Controls.Add(this.rbCikisTarihi);
            this.gbFiltrele.Controls.Add(this.rbGirisTarihi);
            this.gbFiltrele.Controls.Add(this.rbSoyad);
            this.gbFiltrele.Controls.Add(this.rbAd);
            this.gbFiltrele.Controls.Add(this.btnFiltrele);
            this.gbFiltrele.Controls.Add(this.rbSahipKiraci);
            this.gbFiltrele.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrele.Location = new System.Drawing.Point(12, 25);
            this.gbFiltrele.Name = "gbFiltrele";
            this.gbFiltrele.Size = new System.Drawing.Size(157, 275);
            this.gbFiltrele.TabIndex = 11;
            this.gbFiltrele.TabStop = false;
            this.gbFiltrele.Text = "Filtrele";
            // 
            // rbCikisTarihi
            // 
            this.rbCikisTarihi.AutoSize = true;
            this.rbCikisTarihi.Location = new System.Drawing.Point(6, 150);
            this.rbCikisTarihi.Name = "rbCikisTarihi";
            this.rbCikisTarihi.Size = new System.Drawing.Size(111, 40);
            this.rbCikisTarihi.TabIndex = 7;
            this.rbCikisTarihi.TabStop = true;
            this.rbCikisTarihi.Text = "Daireden Çıkış\r\nTarihi";
            this.rbCikisTarihi.UseVisualStyleBackColor = true;
            this.rbCikisTarihi.CheckedChanged += new System.EventHandler(this.rbCikisTarihi_CheckedChanged);
            // 
            // rbGirisTarihi
            // 
            this.rbGirisTarihi.AutoSize = true;
            this.rbGirisTarihi.Location = new System.Drawing.Point(6, 107);
            this.rbGirisTarihi.Name = "rbGirisTarihi";
            this.rbGirisTarihi.Size = new System.Drawing.Size(101, 40);
            this.rbGirisTarihi.TabIndex = 6;
            this.rbGirisTarihi.TabStop = true;
            this.rbGirisTarihi.Text = "Daireye Giriş\r\nTarihi";
            this.rbGirisTarihi.UseVisualStyleBackColor = true;
            this.rbGirisTarihi.CheckedChanged += new System.EventHandler(this.rbGirisTarihi_CheckedChanged);
            // 
            // rbSoyad
            // 
            this.rbSoyad.AutoSize = true;
            this.rbSoyad.Location = new System.Drawing.Point(6, 79);
            this.rbSoyad.Name = "rbSoyad";
            this.rbSoyad.Size = new System.Drawing.Size(64, 22);
            this.rbSoyad.TabIndex = 5;
            this.rbSoyad.TabStop = true;
            this.rbSoyad.Text = "Soyad";
            this.rbSoyad.UseVisualStyleBackColor = true;
            this.rbSoyad.CheckedChanged += new System.EventHandler(this.rbSoyad_CheckedChanged);
            // 
            // rbAd
            // 
            this.rbAd.AutoSize = true;
            this.rbAd.Location = new System.Drawing.Point(6, 51);
            this.rbAd.Name = "rbAd";
            this.rbAd.Size = new System.Drawing.Size(44, 22);
            this.rbAd.TabIndex = 4;
            this.rbAd.TabStop = true;
            this.rbAd.Text = "Ad";
            this.rbAd.UseVisualStyleBackColor = true;
            this.rbAd.CheckedChanged += new System.EventHandler(this.rbAd_CheckedChanged);
            // 
            // rbSahipKiraci
            // 
            this.rbSahipKiraci.AutoSize = true;
            this.rbSahipKiraci.Location = new System.Drawing.Point(6, 23);
            this.rbSahipKiraci.Name = "rbSahipKiraci";
            this.rbSahipKiraci.Size = new System.Drawing.Size(98, 22);
            this.rbSahipKiraci.TabIndex = 2;
            this.rbSahipKiraci.TabStop = true;
            this.rbSahipKiraci.Text = "Sahip/Kiracı";
            this.rbSahipKiraci.UseVisualStyleBackColor = true;
            this.rbSahipKiraci.CheckedChanged += new System.EventHandler(this.rbSahipKiraci_CheckedChanged);
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnRaporla);
            this.gbIslemler.Controls.Add(this.btnKisiSil);
            this.gbIslemler.Controls.Add(this.btnKisiDuzenle);
            this.gbIslemler.Controls.Add(this.btnKisiEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIslemler.Location = new System.Drawing.Point(12, 306);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(157, 179);
            this.gbIslemler.TabIndex = 13;
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Text = "İşlemler";
            // 
            // btnRaporla
            // 
            this.btnRaporla.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporla.Appearance.Options.UseFont = true;
            this.btnRaporla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporla.ImageOptions.SvgImage")));
            this.btnRaporla.Location = new System.Drawing.Point(6, 139);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(143, 32);
            this.btnRaporla.TabIndex = 4;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKisiSil.Appearance.Options.UseFont = true;
            this.btnKisiSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKisiSil.ImageOptions.SvgImage")));
            this.btnKisiSil.Location = new System.Drawing.Point(6, 101);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(143, 32);
            this.btnKisiSil.TabIndex = 3;
            this.btnKisiSil.Text = "Kişiyi Sil";
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnKisiDuzenle
            // 
            this.btnKisiDuzenle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKisiDuzenle.Appearance.Options.UseFont = true;
            this.btnKisiDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKisiDuzenle.ImageOptions.SvgImage")));
            this.btnKisiDuzenle.Location = new System.Drawing.Point(6, 63);
            this.btnKisiDuzenle.Name = "btnKisiDuzenle";
            this.btnKisiDuzenle.Size = new System.Drawing.Size(143, 32);
            this.btnKisiDuzenle.TabIndex = 2;
            this.btnKisiDuzenle.Text = "Kişiyi Düzenle";
            this.btnKisiDuzenle.Click += new System.EventHandler(this.btnKisiDuzenle_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKisiEkle.Appearance.Options.UseFont = true;
            this.btnKisiEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKisiEkle.ImageOptions.SvgImage")));
            this.btnKisiEkle.Location = new System.Drawing.Point(6, 25);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(143, 32);
            this.btnKisiEkle.TabIndex = 1;
            this.btnKisiEkle.Text = "Kişi Ekle";
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // lblKisiler
            // 
            this.lblKisiler.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKisiler.Appearance.Options.UseFont = true;
            this.lblKisiler.Location = new System.Drawing.Point(74, 6);
            this.lblKisiler.Name = "lblKisiler";
            this.lblKisiler.Size = new System.Drawing.Size(52, 18);
            this.lblKisiler.TabIndex = 12;
            this.lblKisiler.Text = "Kişiler";
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(6, 194);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(130, 26);
            this.txtFiltre.TabIndex = 9;
            // 
            // KisiGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.dgFiltre);
            this.Controls.Add(this.gbFiltrele);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.lblKisiler);
            this.Name = "KisiGoruntule";
            this.Text = "Kişileri Görüntüle | Apartman Yönetim Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltre)).EndInit();
            this.gbFiltrele.ResumeLayout(false);
            this.gbFiltrele.PerformLayout();
            this.gbIslemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFiltre;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private System.Windows.Forms.GroupBox gbFiltrele;
        private System.Windows.Forms.RadioButton rbCikisTarihi;
        private System.Windows.Forms.RadioButton rbGirisTarihi;
        private System.Windows.Forms.RadioButton rbSoyad;
        private System.Windows.Forms.RadioButton rbAd;
        private System.Windows.Forms.RadioButton rbSahipKiraci;
        private System.Windows.Forms.GroupBox gbIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRaporla;
        private DevExpress.XtraEditors.SimpleButton btnKisiSil;
        private DevExpress.XtraEditors.SimpleButton btnKisiDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKisiEkle;
        private DevExpress.XtraEditors.LabelControl lblKisiler;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}