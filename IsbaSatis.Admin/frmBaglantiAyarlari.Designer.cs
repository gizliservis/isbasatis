namespace IsbaSatis.Admin
{
    partial class frmBaglantiAyarlari
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
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.chkSql = new DevExpress.XtraEditors.CheckButton();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.lblCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDbAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(485, 59);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Bağlantı Ayarları";
            // 
            // chkWindows
            // 
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.Location = new System.Drawing.Point(12, 65);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(231, 118);
            this.chkWindows.TabIndex = 8;
            this.chkWindows.Text = "Windows Oturumu";
            // 
            // chkSql
            // 
            this.chkSql.GroupIndex = 1;
            this.chkSql.Location = new System.Drawing.Point(249, 65);
            this.chkSql.Name = "chkSql";
            this.chkSql.Size = new System.Drawing.Size(231, 118);
            this.chkSql.TabIndex = 8;
            this.chkSql.TabStop = false;
            this.chkSql.Text = "Sql Server Oturumu";
            this.chkSql.CheckedChanged += new System.EventHandler(this.chkSql_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(125, 189);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(355, 20);
            this.txtServer.TabIndex = 10;
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.Appearance.Options.UseTextOptions = true;
            this.lblCariKodu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblCariKodu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCariKodu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCariKodu.Location = new System.Drawing.Point(12, 191);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(107, 15);
            this.lblCariKodu.TabIndex = 9;
            this.lblCariKodu.Text = "Server Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 217);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 15);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "DB Adı :";
            // 
            // txtDbAdi
            // 
            this.txtDbAdi.Location = new System.Drawing.Point(125, 215);
            this.txtDbAdi.Name = "txtDbAdi";
            this.txtDbAdi.Size = new System.Drawing.Size(355, 20);
            this.txtDbAdi.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 243);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 15);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kullanıcı Adı :";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Enabled = false;
            this.txtKullanici.Location = new System.Drawing.Point(125, 241);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(355, 20);
            this.txtKullanici.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 15);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Parola  :";
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Location = new System.Drawing.Point(125, 267);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(355, 20);
            this.txtParola.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 291);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(231, 55);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(249, 291);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(231, 55);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Server Test";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmBaglantiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 350);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDbAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblCariKodu);
            this.Controls.Add(this.chkSql);
            this.Controls.Add(this.chkWindows);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaglantiAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaglantiAyarlari_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSql;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl lblCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDbAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}