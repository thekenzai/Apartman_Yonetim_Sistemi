namespace Apartman_Yonetim_Sistemi.Ekle
{
    partial class DaireEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaireEkle));
            this.lblDaireler = new DevExpress.XtraEditors.LabelControl();
            this.cbDaireSakini = new System.Windows.Forms.ComboBox();
            this.cbDaireSahibi = new System.Windows.Forms.ComboBox();
            this.lblDaireNo = new DevExpress.XtraEditors.LabelControl();
            this.lblDaireSahibi = new DevExpress.XtraEditors.LabelControl();
            this.lblDaireSakini = new DevExpress.XtraEditors.LabelControl();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.txtDaireNo = new DevExpress.XtraEditors.TextEdit();
            this.cbDaireDurum = new System.Windows.Forms.ComboBox();
            this.lblDaireDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblKat = new DevExpress.XtraEditors.LabelControl();
            this.nudKat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDaireler
            // 
            this.lblDaireler.Appearance.Font = new System.Drawing.Font("Exotc350 DmBd BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireler.Appearance.Options.UseFont = true;
            this.lblDaireler.Location = new System.Drawing.Point(81, 12);
            this.lblDaireler.Name = "lblDaireler";
            this.lblDaireler.Size = new System.Drawing.Size(156, 56);
            this.lblDaireler.TabIndex = 53;
            this.lblDaireler.Text = "Daireler";
            // 
            // cbDaireSakini
            // 
            this.cbDaireSakini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireSakini.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaireSakini.FormattingEnabled = true;
            this.cbDaireSakini.Location = new System.Drawing.Point(141, 169);
            this.cbDaireSakini.Name = "cbDaireSakini";
            this.cbDaireSakini.Size = new System.Drawing.Size(138, 24);
            this.cbDaireSakini.TabIndex = 68;
            // 
            // cbDaireSahibi
            // 
            this.cbDaireSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireSahibi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaireSahibi.FormattingEnabled = true;
            this.cbDaireSahibi.Location = new System.Drawing.Point(141, 139);
            this.cbDaireSahibi.Name = "cbDaireSahibi";
            this.cbDaireSahibi.Size = new System.Drawing.Size(138, 24);
            this.cbDaireSahibi.TabIndex = 67;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireNo.Appearance.Options.UseFont = true;
            this.lblDaireNo.Location = new System.Drawing.Point(26, 84);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(103, 16);
            this.lblDaireNo.TabIndex = 66;
            this.lblDaireNo.Text = "Daire Numarası:";
            // 
            // lblDaireSahibi
            // 
            this.lblDaireSahibi.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireSahibi.Appearance.Options.UseFont = true;
            this.lblDaireSahibi.Location = new System.Drawing.Point(46, 142);
            this.lblDaireSahibi.Name = "lblDaireSahibi";
            this.lblDaireSahibi.Size = new System.Drawing.Size(83, 16);
            this.lblDaireSahibi.TabIndex = 65;
            this.lblDaireSahibi.Text = "Daire Sahibi:";
            // 
            // lblDaireSakini
            // 
            this.lblDaireSakini.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireSakini.Appearance.Options.UseFont = true;
            this.lblDaireSakini.Location = new System.Drawing.Point(47, 172);
            this.lblDaireSakini.Name = "lblDaireSakini";
            this.lblDaireSakini.Size = new System.Drawing.Size(82, 16);
            this.lblDaireSakini.TabIndex = 64;
            this.lblDaireSakini.Text = "Daire Sakini:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.ImageOptions.Image")));
            this.btnOnayla.Location = new System.Drawing.Point(99, 239);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(138, 36);
            this.btnOnayla.TabIndex = 63;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(141, 81);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaireNo.Properties.Appearance.Options.UseFont = true;
            this.txtDaireNo.Properties.MaxLength = 4;
            this.txtDaireNo.Size = new System.Drawing.Size(138, 22);
            this.txtDaireNo.TabIndex = 62;
            // 
            // cbDaireDurum
            // 
            this.cbDaireDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaireDurum.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaireDurum.FormattingEnabled = true;
            this.cbDaireDurum.Items.AddRange(new object[] {
            "-",
            "Sahibi",
            "Kiracı"});
            this.cbDaireDurum.Location = new System.Drawing.Point(141, 109);
            this.cbDaireDurum.Name = "cbDaireDurum";
            this.cbDaireDurum.Size = new System.Drawing.Size(138, 24);
            this.cbDaireDurum.TabIndex = 70;
            // 
            // lblDaireDurum
            // 
            this.lblDaireDurum.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireDurum.Appearance.Options.UseFont = true;
            this.lblDaireDurum.Location = new System.Drawing.Point(36, 112);
            this.lblDaireDurum.Name = "lblDaireDurum";
            this.lblDaireDurum.Size = new System.Drawing.Size(93, 16);
            this.lblDaireDurum.TabIndex = 69;
            this.lblDaireDurum.Text = "Daire Durumu:";
            // 
            // lblKat
            // 
            this.lblKat.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKat.Appearance.Options.UseFont = true;
            this.lblKat.Location = new System.Drawing.Point(101, 201);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(28, 16);
            this.lblKat.TabIndex = 71;
            this.lblKat.Text = "Kat:";
            // 
            // nudKat
            // 
            this.nudKat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKat.Location = new System.Drawing.Point(141, 199);
            this.nudKat.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudKat.Name = "nudKat";
            this.nudKat.Size = new System.Drawing.Size(138, 23);
            this.nudKat.TabIndex = 72;
            // 
            // DaireEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 297);
            this.Controls.Add(this.nudKat);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.cbDaireDurum);
            this.Controls.Add(this.lblDaireDurum);
            this.Controls.Add(this.cbDaireSakini);
            this.Controls.Add(this.cbDaireSahibi);
            this.Controls.Add(this.lblDaireNo);
            this.Controls.Add(this.lblDaireSahibi);
            this.Controls.Add(this.lblDaireSakini);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtDaireNo);
            this.Controls.Add(this.lblDaireler);
            this.Name = "DaireEkle";
            this.Text = "Daire Ekle | Apartman Yönetim Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDaireler;
        private System.Windows.Forms.ComboBox cbDaireSakini;
        private System.Windows.Forms.ComboBox cbDaireSahibi;
        private DevExpress.XtraEditors.LabelControl lblDaireNo;
        private DevExpress.XtraEditors.LabelControl lblDaireSahibi;
        private DevExpress.XtraEditors.LabelControl lblDaireSakini;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.TextEdit txtDaireNo;
        private System.Windows.Forms.ComboBox cbDaireDurum;
        private DevExpress.XtraEditors.LabelControl lblDaireDurum;
        private DevExpress.XtraEditors.LabelControl lblKat;
        private System.Windows.Forms.NumericUpDown nudKat;
    }
}