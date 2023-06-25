namespace Apartman_Yonetim_Sistemi.Ekle
{
    partial class OtomatikAidatEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtomatikAidatEkle));
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.lblOtoAidatGirdi = new DevExpress.XtraEditors.LabelControl();
            this.lblTutar = new DevExpress.XtraEditors.LabelControl();
            this.pbOtomatik = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(67, 96);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 16);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(119, 120);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 2;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(119, 91);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(138, 23);
            this.dtpTarih.TabIndex = 4;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.ImageOptions.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(106, 160);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(113, 36);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblOtoAidatGirdi
            // 
            this.lblOtoAidatGirdi.Appearance.Font = new System.Drawing.Font("Exotc350 DmBd BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtoAidatGirdi.Appearance.Options.UseFont = true;
            this.lblOtoAidatGirdi.Location = new System.Drawing.Point(12, 21);
            this.lblOtoAidatGirdi.Name = "lblOtoAidatGirdi";
            this.lblOtoAidatGirdi.Size = new System.Drawing.Size(280, 38);
            this.lblOtoAidatGirdi.TabIndex = 15;
            this.lblOtoAidatGirdi.Text = "Otomatik Aidat Girdisi";
            // 
            // lblTutar
            // 
            this.lblTutar.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.Appearance.Options.UseFont = true;
            this.lblTutar.Location = new System.Drawing.Point(64, 123);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(42, 16);
            this.lblTutar.TabIndex = 16;
            this.lblTutar.Text = "Tutar:";
            // 
            // pbOtomatik
            // 
            this.pbOtomatik.Location = new System.Drawing.Point(67, 216);
            this.pbOtomatik.Name = "pbOtomatik";
            this.pbOtomatik.Size = new System.Drawing.Size(190, 24);
            this.pbOtomatik.TabIndex = 17;
            // 
            // OtomatikAidatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 252);
            this.Controls.Add(this.pbOtomatik);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblOtoAidatGirdi);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTarih);
            this.Name = "OtomatikAidatEkle";
            this.Text = "Otomatik Aidat Ekle | Apartman Yönetim Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.LabelControl lblOtoAidatGirdi;
        private DevExpress.XtraEditors.LabelControl lblTutar;
        private System.Windows.Forms.ProgressBar pbOtomatik;
    }
}