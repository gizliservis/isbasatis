using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tools
{
    public static class RolTool
    {
        public static Kullanici KullaniciEntity;
        public static void RolleriYukle(XtraForm form)
        {
            IsbaSatisContext context = new IsbaSatisContext();
            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi == form.Name && c.Yetki == false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();

                if (bulunan != null)
                {
                    bulunan.Enabled = false;
                }

            }
        }
        public static void RolleriYukle(RibbonControl form)
        {
            IsbaSatisContext context = new IsbaSatisContext();
            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi == "FrmAnaMenu" && c.Yetki == false).ToList())
            {

                var bulan = form.Items.Where(c => c.Name == item.KontrolAdi).SingleOrDefault() ;
                if (bulan!=null)
                {
                    bulan.Enabled = false;
                }
              

            }
        }
    }
}
