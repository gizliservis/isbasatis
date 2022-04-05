
namespace IsbaSatis.Admin
{
    partial class frmDevir
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.flowKaynak = new System.Windows.Forms.FlowLayoutPanel();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.flowHedef = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(838, 474);
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(778, 307);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.flowKaynak);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(778, 307);
            this.wizardPage1.Text = "Kaynak Veri Tabanını Seçin";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(778, 307);
            // 
            // flowKaynak
            // 
            this.flowKaynak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowKaynak.Location = new System.Drawing.Point(0, 0);
            this.flowKaynak.Name = "flowKaynak";
            this.flowKaynak.Size = new System.Drawing.Size(778, 307);
            this.flowKaynak.TabIndex = 0;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.flowHedef);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(778, 307);
            this.wizardPage2.Text = "Hedef Veri Tabanı";
            // 
            // flowHedef
            // 
            this.flowHedef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowHedef.Location = new System.Drawing.Point(0, 0);
            this.flowHedef.Name = "flowHedef";
            this.flowHedef.Size = new System.Drawing.Size(778, 307);
            this.flowHedef.TabIndex = 0;
            // 
            // frmDevir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 474);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevir";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private System.Windows.Forms.FlowLayoutPanel flowKaynak;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private System.Windows.Forms.FlowLayoutPanel flowHedef;
    }
}