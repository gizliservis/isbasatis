using Isbasatis.LisansManager.SystemInformations.Manager;
using Isbasatis.LisansManager.SystemInformations.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Isbasatis.LicenseManager.Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            SystemInformations manager = new SystemInformations();
            //List<OperatiingSystem> list = new List<OperatiingSystem>();
            //list.Add(manager.GetOSInfo());
            gridControl1.DataSource = manager.GetDiskLis();
        }
    }
}
