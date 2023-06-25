namespace Apartman_Yonetim_Sistemi.Ekle
{
    partial class AidatEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AidatEkle));
            this.lblAidatNo = new DevExpress.XtraEditors.LabelControl();
            this.txtAidatNo = new DevExpress.XtraEditors.TextEdit();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblDaireNo = new DevExpress.XtraEditors.LabelControl();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.txtAidatUcret = new DevExpress.XtraEditors.TextEdit();
            this.lblAidatUcret = new DevExpress.XtraEditors.LabelControl();
            this.txtDemirbas = new DevExpress.XtraEditors.TextEdit();
            this.lblDemirbas = new DevExpress.XtraEditors.LabelControl();
            this.txtToplam = new DevExpress.XtraEditors.TextEdit();
            this.lblToplam = new DevExpress.XtraEditors.LabelControl();
            this.lblAidatGirdi = new DevExpress.XtraEditors.LabelControl();
            this.cbDaireNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAidatNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAidatUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDemirbas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAidatNo
            // 
            this.lblAidatNo.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAidatNo.Appearance.Options.UseFont = true;
            this.lblAidatNo.Location = new System.Drawing.Point(88, 108);
            this.lblAidatNo.Name = "lblAidatNo";
            this.lblAidatNo.Size = new System.Drawing.Size(62, 16);
            this.lblAidatNo.TabIndex = 0;
            this.lblAidatNo.Text = "Aidat No:";
            // 
            // txtAidatNo
            // 
            this.txtAidatNo.Location = new System.Drawing.Point(156, 105);
            this.txtAidatNo.Name = "txtAidatNo";
            this.txtAidatNo.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAidatNo.Properties.Appearance.Options.UseFont = true;
            this.txtAidatNo.Size = new System.Drawing.Size(138, 22);
            this.txtAidatNo.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.ImageOptions.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(111, 286);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(138, 36);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(156, 161);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(138, 23);
            this.dtpTarih.TabIndex = 3;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireNo.Appearance.Options.UseFont = true;
            this.lblDaireNo.Location = new System.Drawing.Point(89, 136);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(61, 16);
            this.lblDaireNo.TabIndex = 4;
            this.lblDaireNo.Text = "Daire No:";
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(111, 164);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 16);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtAidatUcret
            // 
            this.txtAidatUcret.EditValue = "0";
            this.txtAidatUcret.Location = new System.Drawing.Point(156, 189);
            this.txtAidatUcret.Name = "txtAidatUcret";
            this.txtAidatUcret.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAidatUcret.Properties.Appearance.Options.UseFont = true;
            this.txtAidatUcret.Properties.MaxLength = 10;
            this.txtAidatUcret.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAidatUcret.Size = new System.Drawing.Size(138, 22);
            this.txtAidatUcret.TabIndex = 9;
            this.txtAidatUcret.EditValueChanged += new System.EventHandler(this.txtAidatUcret_EditValueChanged);
            // 
            // lblAidatUcret
            // 
            this.lblAidatUcret.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAidatUcret.Appearance.Options.UseFont = true;
            this.lblAidatUcret.Location = new System.Drawing.Point(66, 192);
            this.lblAidatUcret.Name = "lblAidatUcret";
            this.lblAidatUcret.Size = new System.Drawing.Size(84, 16);
            this.lblAidatUcret.TabIndex = 8;
            this.lblAidatUcret.Text = "Aidat Ücreti:";
            // 
            // txtDemirbas
            // 
            this.txtDemirbas.EditValue = "0";
            this.txtDemirbas.Location = new System.Drawing.Point(156, 217);
            this.txtDemirbas.Name = "txtDemirbas";
            this.txtDemirbas.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemirbas.Properties.Appearance.Options.UseFont = true;
            this.txtDemirbas.Properties.MaxLength = 10;
            this.txtDemirbas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDemirbas.Size = new System.Drawing.Size(138, 22);
            this.txtDemirbas.TabIndex = 11;
            this.txtDemirbas.EditValueChanged += new System.EventHandler(this.txtDemirbas_EditValueChanged);
            // 
            // lblDemirbas
            // 
            this.lblDemirbas.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbas.Appearance.Options.UseFont = true;
            this.lblDemirbas.Location = new System.Drawing.Point(28, 220);
            this.lblDemirbas.Name = "lblDemirbas";
            this.lblDemirbas.Size = new System.Drawing.Size(122, 16);
            this.lblDemirbas.TabIndex = 10;
            this.lblDemirbas.Text = "Demirbaş Giderleri:";
            // 
            // txtToplam
            // 
            this.txtToplam.EditValue = "0";
            this.txtToplam.Location = new System.Drawing.Point(156, 245);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplam.Properties.Appearance.Options.UseFont = true;
            this.txtToplam.Properties.MaxLength = 10;
            this.txtToplam.Properties.ReadOnly = true;
            this.txtToplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToplam.Size = new System.Drawing.Size(138, 22);
            this.txtToplam.TabIndex = 13;
            // 
            // lblToplam
            // 
            this.lblToplam.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.Appearance.Options.UseFont = true;
            this.lblToplam.Location = new System.Drawing.Point(56, 248);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(94, 16);
            this.lblToplam.TabIndex = 12;
            this.lblToplam.Text = "Toplam Tutar:";
            // 
            // lblAidatGirdi
            // 
            this.lblAidatGirdi.Appearance.Font = new System.Drawing.Font("Exotc350 DmBd BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAidatGirdi.Appearance.Options.UseFont = true;
            this.lblAidatGirdi.Location = new System.Drawing.Point(15, 12);
            this.lblAidatGirdi.Name = "lblAidatGirdi";
            this.lblAidatGirdi.Size = new System.Drawing.Size(318, 75);
            this.lblAidatGirdi.TabIndex = 14;
            this.lblAidatGirdi.Text = "Aidat Girdisi";
            // 
            // cbDaireNo
            // 
            this.cbDaireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaireNo.FormattingEnabled = true;
            this.cbDaireNo.Location = new System.Drawing.Point(156, 132);
            this.cbDaireNo.Name = "cbDaireNo";
            this.cbDaireNo.Size = new System.Drawing.Size(138, 24);
            this.cbDaireNo.TabIndex = 15;
            // 
            // AidatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.Controls.Add(this.cbDaireNo);
            this.Controls.Add(this.lblAidatGirdi);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtDemirbas);
            this.Controls.Add(this.lblDemirbas);
            this.Controls.Add(this.txtAidatUcret);
            this.Controls.Add(this.lblAidatUcret);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblDaireNo);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtAidatNo);
            this.Controls.Add(this.lblAidatNo);
            this.Name = "AidatEkle";
            this.Text = "Aidat Ekle | Apartman Yönetim Sistemi";
            this.Load += new System.EventHandler(this.AidatEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAidatNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAidatUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDemirbas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAidatNo;
        private DevExpress.XtraEditors.TextEdit txtAidatNo;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private DevExpress.XtraEditors.LabelControl lblDaireNo;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.TextEdit txtAidatUcret;
        private DevExpress.XtraEditors.LabelControl lblAidatUcret;
        private DevExpress.XtraEditors.TextEdit txtDemirbas;
        private DevExpress.XtraEditors.LabelControl lblDemirbas;
        private DevExpress.XtraEditors.TextEdit txtToplam;
        private DevExpress.XtraEditors.LabelControl lblToplam;
        private DevExpress.XtraEditors.LabelControl lblAidatGirdi;
        private System.Windows.Forms.ComboBox cbDaireNo;
    }
}