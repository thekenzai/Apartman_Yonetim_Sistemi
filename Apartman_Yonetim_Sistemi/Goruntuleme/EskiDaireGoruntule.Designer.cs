namespace Apartman_Yonetim_Sistemi.Goruntuleme
{
    partial class EskiDaireGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EskiDaireGoruntule));
            this.dgFiltre = new System.Windows.Forms.DataGridView();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.gbFiltrele = new System.Windows.Forms.GroupBox();
            this.rbDaireSakini = new System.Windows.Forms.RadioButton();
            this.rbDaireSahibi = new System.Windows.Forms.RadioButton();
            this.rbDaireDurum = new System.Windows.Forms.RadioButton();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaireSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaireDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDaireEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblDaireler = new DevExpress.XtraEditors.LabelControl();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltre)).BeginInit();
            this.gbFiltrele.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiltre
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFiltre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltre.Location = new System.Drawing.Point(169, 0);
            this.dgFiltre.MultiSelect = false;
            this.dgFiltre.Name = "dgFiltre";
            this.dgFiltre.ReadOnly = true;
            this.dgFiltre.Size = new System.Drawing.Size(683, 495);
            this.dgFiltre.TabIndex = 10;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Appearance.Options.UseFont = true;
            this.btnFiltrele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFiltrele.ImageOptions.SvgImage")));
            this.btnFiltrele.Location = new System.Drawing.Point(6, 141);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(142, 32);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // gbFiltrele
            // 
            this.gbFiltrele.Controls.Add(this.txtFiltre);
            this.gbFiltrele.Controls.Add(this.rbDaireSakini);
            this.gbFiltrele.Controls.Add(this.rbDaireSahibi);
            this.gbFiltrele.Controls.Add(this.rbDaireDurum);
            this.gbFiltrele.Controls.Add(this.btnFiltrele);
            this.gbFiltrele.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrele.Location = new System.Drawing.Point(6, 73);
            this.gbFiltrele.Name = "gbFiltrele";
            this.gbFiltrele.Size = new System.Drawing.Size(157, 193);
            this.gbFiltrele.TabIndex = 11;
            this.gbFiltrele.TabStop = false;
            this.gbFiltrele.Text = "Filtrele";
            // 
            // rbDaireSakini
            // 
            this.rbDaireSakini.AutoSize = true;
            this.rbDaireSakini.Location = new System.Drawing.Point(6, 83);
            this.rbDaireSakini.Name = "rbDaireSakini";
            this.rbDaireSakini.Size = new System.Drawing.Size(97, 22);
            this.rbDaireSakini.TabIndex = 5;
            this.rbDaireSakini.TabStop = true;
            this.rbDaireSakini.Text = "Daire Sakini";
            this.rbDaireSakini.UseVisualStyleBackColor = true;
            this.rbDaireSakini.CheckedChanged += new System.EventHandler(this.rbDaireSakini_CheckedChanged);
            // 
            // rbDaireSahibi
            // 
            this.rbDaireSahibi.AutoSize = true;
            this.rbDaireSahibi.Location = new System.Drawing.Point(6, 53);
            this.rbDaireSahibi.Name = "rbDaireSahibi";
            this.rbDaireSahibi.Size = new System.Drawing.Size(98, 22);
            this.rbDaireSahibi.TabIndex = 4;
            this.rbDaireSahibi.TabStop = true;
            this.rbDaireSahibi.Text = "Daire Sahibi";
            this.rbDaireSahibi.UseVisualStyleBackColor = true;
            this.rbDaireSahibi.CheckedChanged += new System.EventHandler(this.rbDaireSahibi_CheckedChanged);
            // 
            // rbDaireDurum
            // 
            this.rbDaireDurum.AutoSize = true;
            this.rbDaireDurum.Location = new System.Drawing.Point(6, 23);
            this.rbDaireDurum.Name = "rbDaireDurum";
            this.rbDaireDurum.Size = new System.Drawing.Size(112, 22);
            this.rbDaireDurum.TabIndex = 2;
            this.rbDaireDurum.TabStop = true;
            this.rbDaireDurum.Text = "Daire Durumu";
            this.rbDaireDurum.UseVisualStyleBackColor = true;
            this.rbDaireDurum.CheckedChanged += new System.EventHandler(this.rbDaireDurum_CheckedChanged);
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnRaporla);
            this.gbIslemler.Controls.Add(this.btnDaireSil);
            this.gbIslemler.Controls.Add(this.btnDaireDuzenle);
            this.gbIslemler.Controls.Add(this.btnDaireEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIslemler.Location = new System.Drawing.Point(6, 272);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(157, 211);
            this.gbIslemler.TabIndex = 13;
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
            // btnDaireSil
            // 
            this.btnDaireSil.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireSil.Appearance.Options.UseFont = true;
            this.btnDaireSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaireSil.ImageOptions.SvgImage")));
            this.btnDaireSil.Location = new System.Drawing.Point(5, 118);
            this.btnDaireSil.Name = "btnDaireSil";
            this.btnDaireSil.Size = new System.Drawing.Size(143, 32);
            this.btnDaireSil.TabIndex = 3;
            this.btnDaireSil.Text = "Daireyi Kaydını\r\nSil";
            this.btnDaireSil.Click += new System.EventHandler(this.btnDaireSil_Click);
            // 
            // btnDaireDuzenle
            // 
            this.btnDaireDuzenle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireDuzenle.Appearance.Options.UseFont = true;
            this.btnDaireDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaireDuzenle.ImageOptions.SvgImage")));
            this.btnDaireDuzenle.Location = new System.Drawing.Point(5, 71);
            this.btnDaireDuzenle.Name = "btnDaireDuzenle";
            this.btnDaireDuzenle.Size = new System.Drawing.Size(143, 32);
            this.btnDaireDuzenle.TabIndex = 2;
            this.btnDaireDuzenle.Text = "Daireyi Kaydını\r\nDüzenle";
            this.btnDaireDuzenle.Click += new System.EventHandler(this.btnDaireDuzenle_Click);
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
            this.btnDaireEkle.Text = "Daire Kaydı\r\nEkle";
            this.btnDaireEkle.Click += new System.EventHandler(this.btnDaireEkle_Click);
            // 
            // lblDaireler
            // 
            this.lblDaireler.Appearance.Font = new System.Drawing.Font("Exotc350 DmBd BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireler.Appearance.Options.UseFont = true;
            this.lblDaireler.Location = new System.Drawing.Point(40, 12);
            this.lblDaireler.Name = "lblDaireler";
            this.lblDaireler.Size = new System.Drawing.Size(84, 50);
            this.lblDaireler.TabIndex = 12;
            this.lblDaireler.Text = "Eski Daire\r\nKayıtları";
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(6, 109);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(130, 26);
            this.txtFiltre.TabIndex = 7;
            // 
            // EskiDaireGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 495);
            this.Controls.Add(this.dgFiltre);
            this.Controls.Add(this.gbFiltrele);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.lblDaireler);
            this.Name = "EskiDaireGoruntule";
            this.Text = "Eski Daire Kayıtlarını Görüntüle | Apartman Yönetim Sistemi";
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
        private System.Windows.Forms.RadioButton rbDaireSakini;
        private System.Windows.Forms.RadioButton rbDaireSahibi;
        private System.Windows.Forms.RadioButton rbDaireDurum;
        private System.Windows.Forms.GroupBox gbIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRaporla;
        private DevExpress.XtraEditors.SimpleButton btnDaireSil;
        private DevExpress.XtraEditors.SimpleButton btnDaireDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnDaireEkle;
        private DevExpress.XtraEditors.LabelControl lblDaireler;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}