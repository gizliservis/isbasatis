using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Isbasatis.Entities.Context;
using System.Data.Entity;

namespace IsbaSatis.BackOffice.ajanda
{
    public partial class frmAjanda : DevExpress.XtraEditors.XtraForm
    {
        IsbaSatisContext context = new IsbaSatisContext();
        public frmAjanda()
        {
            InitializeComponent();
            
            context.EFAppointments.Load();
            context.EFResources.Load();

            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();

        }

        private void frmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }
    }
}