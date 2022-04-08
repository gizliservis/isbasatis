﻿using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaSatis.BackOffice.Raporlar
{
    public partial class frmBankaHareketRaporu : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        BankaHareketDAL bankaHrkDal = new BankaHareketDAL();
        private ExportTool export;
        string filename = "BankaHaretlerRpt.xml";
        public frmBankaHareketRaporu()
        {
            InitializeComponent();
            dateBaslangic.DateTime = DateTime.Now;
            dateBitis.DateTime = DateTime.Now;
            export = new ExportTool(this, gridView1, dropDownButton1, filename);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
            listele();

        }
        public void listele()
        {
            gridControl1.DataSource = bankaHrkDal.BankaHareketleri(context, dateBaslangic.DateTime, dateBitis.DateTime);

        }

        private void BtnHazırla_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}