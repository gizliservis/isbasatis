
namespace IsbaSatis.LicenseManager.LicenseServer
{
    partial class Form1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtSirketAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtLisansSayisi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerDurumu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(722, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(732, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(280, 34);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Server Başlat";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(732, 52);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(280, 393);
            this.memoEdit1.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(732, 453);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(199, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(937, 451);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Gönder";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl3.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(3, 451);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 22);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Lisans Sayısı :";
            // 
            // labelControl2
            // 
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(3, 424);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 21);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Şirket İsmi :";
            // 
            // labelControl1
            // 
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(5, 396);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AppearancePressed.Options.UseTextOptions = true;
            this.txtKullaniciAdi.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtKullaniciAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtKullaniciAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(88, 396);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(638, 22);
            this.txtKullaniciAdi.TabIndex = 9;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.AppearancePressed.Options.UseTextOptions = true;
            this.txtSirketAdi.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSirketAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtSirketAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSirketAdi.Location = new System.Drawing.Point(88, 424);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(638, 21);
            this.txtSirketAdi.TabIndex = 9;
            this.txtSirketAdi.Text = "Kullanıcı Adı :";
            // 
            // txtLisansSayisi
            // 
            this.txtLisansSayisi.AppearancePressed.Options.UseTextOptions = true;
            this.txtLisansSayisi.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLisansSayisi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtLisansSayisi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLisansSayisi.Location = new System.Drawing.Point(88, 451);
            this.txtLisansSayisi.Name = "txtLisansSayisi";
            this.txtLisansSayisi.Size = new System.Drawing.Size(638, 22);
            this.txtLisansSayisi.TabIndex = 9;
            this.txtLisansSayisi.Text = "Kullanıcı Adı :";
            // 
            // labelControl4
            // 
            this.labelControl4.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl4.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 368);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 22);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Server Durumu:";
            // 
            // txtServerDurumu
            // 
            this.txtServerDurumu.AppearancePressed.Options.UseTextOptions = true;
            this.txtServerDurumu.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtServerDurumu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtServerDurumu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtServerDurumu.Location = new System.Drawing.Point(88, 368);
            this.txtServerDurumu.Name = "txtServerDurumu";
            this.txtServerDurumu.Size = new System.Drawing.Size(638, 22);
            this.txtServerDurumu.TabIndex = 9;
            this.txtServerDurumu.Text = "Başlatılmadı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 484);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLisansSayisi);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.txtServerDurumu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl txtSirketAdi;
        private DevExpress.XtraEditors.LabelControl txtLisansSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl txtServerDurumu;
    }
}

