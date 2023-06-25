namespace Apartman_Yonetim_Sistemi
{
    partial class AracGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracGoruntule));
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.rbPlaka = new System.Windows.Forms.RadioButton();
            this.gbFiltre = new System.Windows.Forms.GroupBox();
            this.rbModel = new System.Windows.Forms.RadioButton();
            this.rbMarka = new System.Windows.Forms.RadioButton();
            this.lblTasit = new DevExpress.XtraEditors.LabelControl();
            this.gbIslemler = new System.Windows.Forms.GroupBox();
            this.btnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.btnAracSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAracDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAracEkle = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.gbFiltre.SuspendLayout();
            this.gbIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltre
            // 
            this.btnFiltre.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltre.Appearance.Options.UseFont = true;
            this.btnFiltre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltre.ImageOptions.Image")));
            this.btnFiltre.Location = new System.Drawing.Point(6, 131);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(130, 37);
            this.btnFiltre.TabIndex = 0;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // rbPlaka
            // 
            this.rbPlaka.AutoSize = true;
            this.rbPlaka.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlaka.Location = new System.Drawing.Point(6, 25);
            this.rbPlaka.Name = "rbPlaka";
            this.rbPlaka.Size = new System.Drawing.Size(60, 20);
            this.rbPlaka.TabIndex = 2;
            this.rbPlaka.TabStop = true;
            this.rbPlaka.Text = "Plaka";
            this.rbPlaka.UseVisualStyleBackColor = true;
            this.rbPlaka.CheckedChanged += new System.EventHandler(this.rbPlaka_CheckedChanged);
            // 
            // gbFiltre
            // 
            this.gbFiltre.Controls.Add(this.txtFiltre);
            this.gbFiltre.Controls.Add(this.rbModel);
            this.gbFiltre.Controls.Add(this.rbPlaka);
            this.gbFiltre.Controls.Add(this.btnFiltre);
            this.gbFiltre.Controls.Add(this.rbMarka);
            this.gbFiltre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltre.Location = new System.Drawing.Point(12, 36);
            this.gbFiltre.Name = "gbFiltre";
            this.gbFiltre.Size = new System.Drawing.Size(142, 179);
            this.gbFiltre.TabIndex = 3;
            this.gbFiltre.TabStop = false;
            this.gbFiltre.Text = "Filtrele";
            // 
            // rbModel
            // 
            this.rbModel.AutoSize = true;
            this.rbModel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModel.Location = new System.Drawing.Point(6, 77);
            this.rbModel.Name = "rbModel";
            this.rbModel.Size = new System.Drawing.Size(64, 20);
            this.rbModel.TabIndex = 5;
            this.rbModel.TabStop = true;
            this.rbModel.Text = "Model";
            this.rbModel.UseVisualStyleBackColor = true;
            this.rbModel.CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);
            // 
            // rbMarka
            // 
            this.rbMarka.AutoSize = true;
            this.rbMarka.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarka.Location = new System.Drawing.Point(6, 51);
            this.rbMarka.Name = "rbMarka";
            this.rbMarka.Size = new System.Drawing.Size(65, 20);
            this.rbMarka.TabIndex = 4;
            this.rbMarka.TabStop = true;
            this.rbMarka.Text = "Marka";
            this.rbMarka.UseVisualStyleBackColor = true;
            this.rbMarka.CheckedChanged += new System.EventHandler(this.rbMarka_CheckedChanged);
            // 
            // lblTasit
            // 
            this.lblTasit.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasit.Appearance.Options.UseFont = true;
            this.lblTasit.Location = new System.Drawing.Point(43, 12);
            this.lblTasit.Name = "lblTasit";
            this.lblTasit.Size = new System.Drawing.Size(66, 18);
            this.lblTasit.TabIndex = 0;
            this.lblTasit.Text = "Taşıtlar";
            // 
            // gbIslemler
            // 
            this.gbIslemler.Controls.Add(this.btnRapor);
            this.gbIslemler.Controls.Add(this.btnAracSil);
            this.gbIslemler.Controls.Add(this.btnAracDuzenle);
            this.gbIslemler.Controls.Add(this.btnAracEkle);
            this.gbIslemler.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIslemler.Location = new System.Drawing.Point(12, 237);
            this.gbIslemler.Name = "gbIslemler";
            this.gbIslemler.Size = new System.Drawing.Size(142, 206);
            this.gbIslemler.TabIndex = 6;
            this.gbIslemler.TabStop = false;
            this.gbIslemler.Text = "İşlemler";
            // 
            // btnRapor
            // 
            this.btnRapor.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Appearance.Options.UseFont = true;
            this.btnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRapor.ImageOptions.Image")));
            this.btnRapor.Location = new System.Drawing.Point(6, 157);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(130, 37);
            this.btnRapor.TabIndex = 3;
            this.btnRapor.Text = "Raporla";
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracSil.Appearance.Options.UseFont = true;
            this.btnAracSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracSil.ImageOptions.Image")));
            this.btnAracSil.Location = new System.Drawing.Point(6, 114);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(130, 37);
            this.btnAracSil.TabIndex = 2;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracDuzenle
            // 
            this.btnAracDuzenle.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracDuzenle.Appearance.Options.UseFont = true;
            this.btnAracDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracDuzenle.ImageOptions.Image")));
            this.btnAracDuzenle.Location = new System.Drawing.Point(6, 71);
            this.btnAracDuzenle.Name = "btnAracDuzenle";
            this.btnAracDuzenle.Size = new System.Drawing.Size(130, 37);
            this.btnAracDuzenle.TabIndex = 1;
            this.btnAracDuzenle.Text = "Araç Düzenle";
            this.btnAracDuzenle.Click += new System.EventHandler(this.btnAracDuzenle_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracEkle.Appearance.Options.UseFont = true;
            this.btnAracEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracEkle.ImageOptions.Image")));
            this.btnAracEkle.Location = new System.Drawing.Point(6, 25);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(130, 37);
            this.btnAracEkle.TabIndex = 0;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 476);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(6, 103);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(130, 26);
            this.txtFiltre.TabIndex = 6;
            // 
            // AracGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(783, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbIslemler);
            this.Controls.Add(this.lblTasit);
            this.Controls.Add(this.gbFiltre);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AracGoruntule";
            this.Text = "Taşıtları Görüntüle | Apartman Yönetim Sistemi";
            this.gbFiltre.ResumeLayout(false);
            this.gbFiltre.PerformLayout();
            this.gbIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private System.Windows.Forms.RadioButton rbPlaka;
        private System.Windows.Forms.GroupBox gbFiltre;
        private System.Windows.Forms.RadioButton rbModel;
        private System.Windows.Forms.RadioButton rbMarka;
        private DevExpress.XtraEditors.LabelControl lblTasit;
        private System.Windows.Forms.GroupBox gbIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRapor;
        private DevExpress.XtraEditors.SimpleButton btnAracSil;
        private DevExpress.XtraEditors.SimpleButton btnAracDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnAracEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}