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
    public partial class frmKasaBakiyeRaporu : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        KasaDAL kasaDal = new KasaDAL();
        private ExportTool export;
        string filename = "KasaBakiyeRpt.xml";
        public frmKasaBakiyeRaporu()
        {
            InitializeComponent();
            BakiyeListele();
            FileInfo fi = new FileInfo(Application.StartupPath + "\\" + filename);
            if (fi.Exists)
            {
                gridView1.RestoreLayoutFromXml(filename);
            }
        }
        public void BakiyeListele()
        {
            gridControl1.DataSource = kasaDal.KasaListele(context);
        }
    }
}