namespace Apartman_Yonetim_Sistemi
{
    partial class KullaniciSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciSifreDegistir));
            this.lblGecerliSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblSifreDegistir = new DevExpress.XtraEditors.LabelControl();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.lblYeniSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblSifreOnay = new DevExpress.XtraEditors.LabelControl();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.txtGecerliSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtSifreOnay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGecerliSifre
            // 
            this.lblGecerliSifre.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGecerliSifre.Appearance.Options.UseFont = true;
            this.lblGecerliSifre.Location = new System.Drawing.Point(25, 93);
            this.lblGecerliSifre.Name = "lblGecerliSifre";
            this.lblGecerliSifre.Size = new System.Drawing.Size(85, 16);
            this.lblGecerliSifre.TabIndex = 60;
            this.lblGecerliSifre.Text = "Geçerli Şifre:";
            // 
            // lblSifreDegistir
            // 
            this.lblSifreDegistir.Appearance.Font = new System.Drawing.Font("Exotc350 DmBd BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifreDegistir.Appearance.Options.UseFont = true;
            this.lblSifreDegistir.Location = new System.Drawing.Point(58, 26);
            this.lblSifreDegistir.Name = "lblSifreDegistir";
            this.lblSifreDegistir.Size = new System.Drawing.Size(166, 38);
            this.lblSifreDegistir.TabIndex = 59;
            this.lblSifreDegistir.Text = "Şifre Değiştir";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.ImageOptions.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(86, 220);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(138, 36);
            this.btnOnayla.TabIndex = 58;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYeniSifre.Appearance.Options.UseFont = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(41, 122);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(69, 16);
            this.lblYeniSifre.TabIndex = 62;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // lblSifreOnay
            // 
            this.lblSifreOnay.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifreOnay.Appearance.Options.UseFont = true;
            this.lblSifreOnay.Location = new System.Drawing.Point(24, 151);
            this.lblSifreOnay.Name = "lblSifreOnay";
            this.lblSifreOnay.Size = new System.Drawing.Size(86, 16);
            this.lblSifreOnay.TabIndex = 64;
            this.lblSifreOnay.Text = "Şifre Onayla:";
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.Location = new System.Drawing.Point(97, 183);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(116, 20);
            this.cbSifreGoster.TabIndex = 65;
            this.cbSifreGoster.Text = "Şifreyi Göster";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged);
            // 
            // txtGecerliSifre
            // 
            this.txtGecerliSifre.Location = new System.Drawing.Point(124, 90);
            this.txtGecerliSifre.MaxLength = 8;
            this.txtGecerliSifre.Name = "txtGecerliSifre";
            this.txtGecerliSifre.Size = new System.Drawing.Size(133, 23);
            this.txtGecerliSifre.TabIndex = 66;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(124, 119);
            this.txtYeniSifre.MaxLength = 8;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(133, 23);
            this.txtYeniSifre.TabIndex = 67;
            // 
            // txtSifreOnay
            // 
            this.txtSifreOnay.Location = new System.Drawing.Point(124, 148);
            this.txtSifreOnay.MaxLength = 8;
            this.txtSifreOnay.Name = "txtSifreOnay";
            this.txtSifreOnay.Size = new System.Drawing.Size(133, 23);
            this.txtSifreOnay.TabIndex = 68;
            // 
            // KullaniciSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 268);
            this.Controls.Add(this.txtSifreOnay);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtGecerliSifre);
            this.Controls.Add(this.cbSifreGoster);
            this.Controls.Add(this.lblSifreOnay);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.lblGecerliSifre);
            this.Controls.Add(this.lblSifreDegistir);
            this.Controls.Add(this.btnOnayla);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Şifresi Değiştir | Apartman Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblGecerliSifre;
        private DevExpress.XtraEditors.LabelControl lblSifreDegistir;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.LabelControl lblYeniSifre;
        private DevExpress.XtraEditors.LabelControl lblSifreOnay;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.TextBox txtGecerliSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtSifreOnay;
    }
}