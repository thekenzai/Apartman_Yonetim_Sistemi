namespace Apartman_Yonetim_Sistemi
{
    partial class AidatGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatGoruntule));
            this.dgFiltre = new System.Windows.Forms.DataGridView();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.gbFiltrele = new System.Windows.Forms.GroupBox();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.rbTarih = new System.Windows.Forms.RadioButton();
            this.rbDaireNo = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnToplamTutar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaireEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltre)).BeginInit();
            this.gbFiltrele.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiltre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiltre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltre.Location = new System.Drawing.Point(161, 12);
            this.dgFiltre.MultiSelect = false;
            this.dgFiltre.Name = "dgFiltre";
            this.dgFiltre.ReadOnly = true;
            this.dgFiltre.Size = new System.Drawing.Size(634, 429);
            this.dgFiltre.TabIndex = 0;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Appearance.Options.UseFont = true;
            this.btnFiltrele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltrele.ImageOptions.SvgImage")));
            this.btnFiltrele.Location = new System.Drawing.Point(5, 106);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(124, 32);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // gbFiltrele
            // 
            this.gbFiltrele.Controls.Add(this.txtFiltre);
            this.gbFiltrele.Controls.Add(this.rbTarih);
            this.gbFiltrele.Controls.Add(this.rbDaireNo);
            this.gbFiltrele.Controls.Add(this.btnFiltrele);
            this.gbFiltrele.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrele.Location = new System.Drawing.Point(7, 43);
            this.gbFiltrele.Name = "gbFiltrele";
            this.gbFiltrele.Size = new System.Drawing.Size(135, 144);
            this.gbFiltrele.TabIndex = 2;
            this.gbFiltrele.TabStop = false;
            this.gbFiltrele.Text = "Filtrele";
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(6, 74);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(116, 26);
            this.txtFiltre.TabIndex = 5;
            // 
            // rbTarih
            // 
            this.rbTarih.AutoSize = true;
            this.rbTarih.Location = new System.Drawing.Point(6, 46);
            this.rbTarih.Name = "rbTarih";
            this.rbTarih.Size = new System.Drawing.Size(56, 22);
            this.rbTarih.TabIndex = 4;
            this.rbTarih.TabStop = true;
            this.rbTarih.Text = "Tarih";
            this.rbTarih.UseVisualStyleBackColor = true;
            this.rbTarih.CheckedChanged += new System.EventHandler(this.rbTarih_CheckedChanged);
            // 
            // rbDaireNo
            // 
            this.rbDaireNo.AutoSize = true;
            this.rbDaireNo.Location = new System.Drawing.Point(6, 18);
            this.rbDaireNo.Name = "rbDaireNo";
            this.rbDaireNo.Size = new System.Drawing.Size(79, 22);
            this.rbDaireNo.TabIndex = 2;
            this.rbDaireNo.TabStop = true;
            this.rbDaireNo.Text = "Daire No";
            this.rbDaireNo.UseVisualStyleBackColor = true;
            this.rbDaireNo.CheckedChanged += new System.EventHandler(this.rbDaireNo_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Aidat Girdileri";
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnToplamTutar);
            this.gbIslemler.Controls.Add(this.btnRaporla);
            this.gbIslemler.Controls.Add(this.btnSil);
            this.gbIslemler.Controls.Add(this.btnDuzenle);
            this.gbIslemler.Controls.Add(this.btnDaireEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIslemler.Location = new System.Drawing.Point(7, 193);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(148, 248);
            this.gbIslemler.TabIndex = 5;
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Text = "İşlemler";
            // 
            // btnToplamTutar
            // 
            this.btnToplamTutar.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToplamTutar.Appearance.Options.UseFont = true;
            this.btnToplamTutar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnToplamTutar.ImageOptions.SvgImage")));
            this.btnToplamTutar.Location = new System.Drawing.Point(5, 210);
            this.btnToplamTutar.Name = "btnToplamTutar";
            this.btnToplamTutar.Size = new System.Drawing.Size(143, 32);
            this.btnToplamTutar.TabIndex = 5;
            this.btnToplamTutar.Text = "Dairenin Toplam\r\nTutarı";
            this.btnToplamTutar.Click += new System.EventHandler(this.btnToplamTutar_Click);
            // 
            // btnRaporla
            // 
            this.btnRaporla.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporla.Appearance.Options.UseFont = true;
            this.btnRaporla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporla.ImageOptions.SvgImage")));
            this.btnRaporla.Location = new System.Drawing.Point(5, 164);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(143, 32);
            this.btnRaporla.TabIndex = 4;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(5, 118);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 32);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Aidat Girdisi\r\nSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDuzenle.ImageOptions.SvgImage")));
            this.btnDuzenle.Location = new System.Drawing.Point(5, 70);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(143, 32);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Aidat Girdisi\r\nDüzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnDaireEkle
            // 
            this.btnDaireEkle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireEkle.Appearance.Options.UseFont = true;
            this.btnDaireEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaireEkle.ImageOptions.SvgImage")));
            this.btnDaireEkle.Location = new System.Drawing.Point(5, 25);
            this.btnDaireEkle.Name = "btnDaireEkle";
            this.btnDaireEkle.Size = new System.Drawing.Size(143, 32);
            this.btnDaireEkle.TabIndex = 1;
            this.btnDaireEkle.Text = "Aidat Girdisi\r\nEkle";
            this.btnDaireEkle.Click += new System.EventHandler(this.btnDaireEkle_Click);
            // 
            // AidatGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gbFiltrele);
            this.Controls.Add(this.dgFiltre);
            this.Name = "AidatGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aidat Girdileri Görüntüle | Apartman Yönetim Sistemi";
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
        private System.Windows.Forms.RadioButton rbTarih;
        private System.Windows.Forms.RadioButton rbDaireNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox gbIslemler;
        private DevExpress.XtraEditors.SimpleButton btnToplamTutar;
        private DevExpress.XtraEditors.SimpleButton btnRaporla;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnDaireEkle;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}