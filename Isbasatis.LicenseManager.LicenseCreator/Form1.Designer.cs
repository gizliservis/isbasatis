
namespace Isbasatis.LicenseManager.LicenseCreator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtCompany = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnLisanOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(97, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(311, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(97, 119);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(311, 20);
            this.txtCompany.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(14, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 24);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 21);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Şirket İsmi :";
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Stok"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Cari"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Fatura"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "StokHareketleri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "KasaHareketleri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "SatisEkrani"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Indirimler"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "TopluFiyatDegisikligi"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "HizliSatisMenusu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Personeller"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Kasalar"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "OdemeTurleri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Depolar"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "EtiketBasimSihirbazi"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "OzgunRaporSihirbazi"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Raporlar"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "RaporOlustur"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Ajanda"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Sms"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Ayarlar"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "DovizKurlari"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Yedekleme")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(12, 145);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(396, 193);
            this.checkedListBoxControl1.TabIndex = 7;
            // 
            // btnLisanOlustur
            // 
            this.btnLisanOlustur.Location = new System.Drawing.Point(14, 344);
            this.btnLisanOlustur.Name = "btnLisanOlustur";
            this.btnLisanOlustur.Size = new System.Drawing.Size(394, 56);
            this.btnLisanOlustur.TabIndex = 8;
            this.btnLisanOlustur.Text = "Lisans Oluştur";
            this.btnLisanOlustur.Click += new System.EventHandler(this.btnLisanOlustur_Click);
            // 
            // checkButton1
            // 
            this.checkButton1.GroupIndex = 1;
            this.checkButton1.Location = new System.Drawing.Point(14, 5);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(196, 78);
            this.checkButton1.TabIndex = 9;
            this.checkButton1.Text = "İstemci Lisansı";
            // 
            // checkButton2
            // 
            this.checkButton2.GroupIndex = 1;
            this.checkButton2.Location = new System.Drawing.Point(216, 5);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(192, 78);
            this.checkButton2.TabIndex = 9;
            this.checkButton2.Text = "Server Lisansı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 402);
            this.Controls.Add(this.checkButton2);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.btnLisanOlustur);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtCompany;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnLisanOlustur;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.CheckButton checkButton2;
    }
}

