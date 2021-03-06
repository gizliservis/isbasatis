﻿using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tools
{
    public class CodeTool
    {
 
        BarManager manager = new BarManager();
        PopupMenu menu = new PopupMenu();
        private XtraForm _form;
        private IsbaSatisContext _context;
        private Table _table;
    

        public enum Table
        {
            Cari,
            Stok,
            Fis
        }
        public CodeTool(XtraForm form, Table table, IsbaSatisContext context)
        {
            _form = form;
            _context = context;
            _table = table;
            manager.Form = _form;
            menu = new PopupMenu(manager);
        }

        public void BarButonOlustur()
        {
            foreach (var kod in _context.Kodlar.Where(c => c.Tablo == _table.ToString()).ToList())
            {
                BarButtonItem item = new BarButtonItem
                {
                    Name ="btnKod"+kod.SonDeger,
                    Tag=kod.Id,
                    Caption=KodOlustur(kod.OnEki,kod.SonDeger)
                };
                item.ItemClick += Button_Click;
                menu.AddItem(item);
              
            }
            BarButtonItem yeniKodEkle = new BarButtonItem
            {
                Name = "btnYeniKodEkle",
                Caption = "Yeni Kod Oluştur"
            };
            yeniKodEkle.ItemClick += YeniKodEkle_Click;
            menu.AddItem(yeniKodEkle);
            DropDownButton buton = (DropDownButton) _form.Controls.Find("btnKod", true).SingleOrDefault();
            buton.MenuManager = manager;
            buton.DropDownControl = menu;
        }

        private void YeniKodEkle_Click(object sender, ItemClickEventArgs e)
        {
            Type tip = Assembly.Load("Isbasatis.BackOffice").GetTypes().SingleOrDefault(c => c.Name == "frmKodlar");
            XtraForm form = (XtraForm)Activator.CreateInstance(tip, _table.ToString());
            form.ShowDialog();
        }

        private void Button_Click(object sender, ItemClickEventArgs e)
        {
            TextEdit text =(TextEdit) _form.Controls.Find("txtKod",true).SingleOrDefault();
            text.Text = e.Item.Caption;
        }

        private string KodOlustur(string kodonEki, int kodsonDeger)
        {
            int sifirsayisi = 12 - (kodonEki.Length + kodsonDeger.ToString().Length);
            string sifirdizis = new string('0',sifirsayisi);
            return kodonEki + sifirdizis + kodsonDeger;
        }
        public void KodArttirma()
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            BarItemLink buton = menu.ItemLinks.SingleOrDefault(c => c.Caption == text.Text);
            if (buton!=null)
            {
                int id =Convert.ToInt32( buton.Item.Tag.ToString());
                _context.Kodlar.SingleOrDefault(c => c.Id == id).SonDeger++;
            }
        }
        //public static string KodOlustur(string OnEki,string Kod)
        //{
        //    int OnEkiUzunluk = OnEki.Length;
        //    int KodUzunluk = Kod.Length;
        //    int KalanKarakter = 12 - (OnEkiUzunluk + KodUzunluk);
        //    string SifirDizisi = null;
        //    for (int i = 0; i < KalanKarakter; i++)
        //    {
        //        SifirDizisi += "0";
        //    }
        //    return OnEki + SifirDizisi + Kod;

        //}
    }
}
