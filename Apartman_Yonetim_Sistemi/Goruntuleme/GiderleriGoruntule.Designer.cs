namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    partial class GiderleriGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderleriGoruntule));
            this.dgFiltre = new System.Windows.Forms.DataGridView();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.gbFiltrele = new System.Windows.Forms.GroupBox();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.rbGiderTuru = new System.Windows.Forms.RadioButton();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiderSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiderDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiderEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblGiderler = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltre)).BeginInit();
            this.gbFiltrele.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiltre
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiltre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltre.Location = new System.Drawing.Point(169, 0);
            this.dgFiltre.MultiSelect = false;
            this.dgFiltre.Name = "dgFiltre";
            this.dgFiltre.ReadOnly = true;
            this.dgFiltre.Size = new System.Drawing.Size(683, 495);
            this.dgFiltre.TabIndex = 14;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Appearance.Options.UseFont = true;
            this.btnFiltrele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltrele.ImageOptions.SvgImage")));
            this.btnFiltrele.Location = new System.Drawing.Point(6, 92);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(142, 32);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // gbFiltrele
            // 
            this.gbFiltrele.Controls.Add(this.txtFiltre);
            this.gbFiltrele.Controls.Add(this.rbGiderTuru);
            this.gbFiltrele.Controls.Add(this.btnFiltrele);
            this.gbFiltrele.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrele.Location = new System.Drawing.Point(6, 54);
            this.gbFiltrele.Name = "gbFiltrele";
            this.gbFiltrele.Size = new System.Drawing.Size(157, 130);
            this.gbFiltrele.TabIndex = 15;
            this.gbFiltrele.TabStop = false;
            this.gbFiltrele.Text = "Filtrele";
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(5, 53);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(130, 26);
            this.txtFiltre.TabIndex = 8;
            // 
            // rbGiderTuru
            // 
            this.rbGiderTuru.AutoSize = true;
            this.rbGiderTuru.Location = new System.Drawing.Point(5, 25);
            this.rbGiderTuru.Name = "rbGiderTuru";
            this.rbGiderTuru.Size = new System.Drawing.Size(89, 22);
            this.rbGiderTuru.TabIndex = 2;
            this.rbGiderTuru.TabStop = true;
            this.rbGiderTuru.Text = "Gider Türü";
            this.rbGiderTuru.UseVisualStyleBackColor = true;
            this.rbGiderTuru.CheckedChanged += new System.EventHandler(this.rbGiderTuru_CheckedChanged);
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnRaporla);
            this.gbIslemler.Controls.Add(this.btnGiderSil);
            this.gbIslemler.Controls.Add(this.btnGiderDuzenle);
            this.gbIslemler.Controls.Add(this.btnGiderEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIslemler.Location = new System.Drawing.Point(6, 230);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(157, 211);
            this.gbIslemler.TabIndex = 17;
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Text = "İşlemler";
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
            // btnGiderSil
            // 
            this.btnGiderSil.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiderSil.Appearance.Options.UseFont = true;
            this.btnGiderSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderSil.ImageOptions.SvgImage")));
            this.btnGiderSil.Location = new System.Drawing.Point(5, 118);
            this.btnGiderSil.Name = "btnGiderSil";
            this.btnGiderSil.Size = new System.Drawing.Size(143, 32);
            this.btnGiderSil.TabIndex = 3;
            this.btnGiderSil.Text = "Gider Sil";
            this.btnGiderSil.Click += new System.EventHandler(this.btnGiderSil_Click);
            // 
            // btnGiderDuzenle
            // 
            this.btnGiderDuzenle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiderDuzenle.Appearance.Options.UseFont = true;
            this.btnGiderDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderDuzenle.ImageOptions.SvgImage")));
            this.btnGiderDuzenle.Location = new System.Drawing.Point(5, 71);
            this.btnGiderDuzenle.Name = "btnGiderDuzenle";
            this.btnGiderDuzenle.Size = new System.Drawing.Size(143, 32);
            this.btnGiderDuzenle.TabIndex = 2;
            this.btnGiderDuzenle.Text = "Giderleri\r\nDüzenle";
            this.btnGiderDuzenle.Click += new System.EventHandler(this.btnGiderDuzenle_Click);
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiderEkle.Appearance.Options.UseFont = true;
            this.btnGiderEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderEkle.ImageOptions.SvgImage")));
            this.btnGiderEkle.Location = new System.Drawing.Point(5, 25);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(143, 32);
            this.btnGiderEkle.TabIndex = 1;
            this.btnGiderEkle.Text = "Gider Ekle";
            this.btnGiderEkle.Click += new System.EventHandler(this.btnGiderEkle_Click);
            // 
            // lblGiderler
            // 
            this.lblGiderler.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiderler.Appearance.Options.UseFont = true;
            this.lblGiderler.Location = new System.Drawing.Point(38, 12);
            this.lblGiderler.Name = "lblGiderler";
            this.lblGiderler.Size = new System.Drawing.Size(70, 18);
            this.lblGiderler.TabIndex = 16;
            this.lblGiderler.Text = "Giderler";
            // 
            // GiderleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 495);
            this.Controls.Add(this.dgFiltre);
            this.Controls.Add(this.gbFiltrele);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.lblGiderler);
            this.Name = "GiderleriGoruntule";
            this.Text = "Apartman Giderlerini Görüntüle | Apartman Yönetim Sistemi";
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
        private System.Windows.Forms.RadioButton rbGiderTuru;
        private System.Windows.Forms.GroupBox gbIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRaporla;
        private DevExpress.XtraEditors.SimpleButton btnGiderSil;
        private DevExpress.XtraEditors.SimpleButton btnGiderDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnGiderEkle;
        private DevExpress.XtraEditors.LabelControl lblGiderler;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}