using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isbasatis.Entities.Tools
{
    public class ExportTool
    {
        private XtraForm _form;
        private DropDownButton _buton;
        private GridView _grid;
        BarManager manager = new BarManager();
        private PopupMenu menu;
        public ExportTool(XtraForm form, GridView grid, DropDownButton dropDown)
        {
            _form = form;
            _grid = grid;
            _buton = dropDown;
            menu = new PopupMenu(manager);
            _buton.MenuManager = manager;
            _buton.DropDownControl = menu;

            //pdf
            BarButtonItem pdfExport = new BarButtonItem
            {
                Name = "pdf",
                Caption = "PDF Dosyası(.pdf)",
                ImageOptions = { Image = Properties.Resources.PDF }

            };
            pdfExport.ItemClick += Export;
            menu.AddItem(pdfExport);

            //xlsx
            BarButtonItem xlsxExport = new BarButtonItem
            {
                Name = "xlsx",
                Caption = "Excell Dosyası(.xlsx)",
                ImageOptions = { Image = Properties.Resources.XLSX }

            };
            xlsxExport.ItemClick += Export;
            menu.AddItem(xlsxExport);

            //xls
            BarButtonItem xlsExport = new BarButtonItem
            {
                Name = "xls",
                Caption = "Excell Dosyası(.xls)",
                ImageOptions = { Image = Properties.Resources.XLS }

            };
            xlsExport.ItemClick += Export;
            menu.AddItem(xlsExport);
            //Html
            BarButtonItem htmlExport = new BarButtonItem
            {
                Name = "html",
                Caption = "HTML Dosyası(.Html)",
                ImageOptions = { Image = Properties.Resources.HTML }

            };
            htmlExport.ItemClick += Export;
            menu.AddItem(htmlExport);
            //Mht
            BarButtonItem mhtExport = new BarButtonItem
            {
                Name = "mht",
                Caption = "MHT Dosyası(.mht)",
                ImageOptions = { Image = Properties.Resources.MHT }

            };
            mhtExport.ItemClick += Export;
            menu.AddItem(mhtExport);
            //rtf
            BarButtonItem rtfExport = new BarButtonItem
            {
                Name = "rtf",
                Caption = "rtf Dosyası(.rtf)",
                ImageOptions = { Image = Properties.Resources.RTF }

            };
            rtfExport.ItemClick += Export;
            menu.AddItem(rtfExport);

            //txt
            BarButtonItem txtExport = new BarButtonItem
            {
                Name = "txt",
                Caption = "txt Dosyası(.txt)",
                ImageOptions = { Image = Properties.Resources.TXT }

            };
            txtExport.ItemClick += Export;
            menu.AddItem(txtExport);

            //docx
            BarButtonItem docxExport = new BarButtonItem
            {
                Name = "docx",
                Caption = "Word Dosyası(.docx)",
                ImageOptions = { Image = Properties.Resources.word }

            };
            docxExport.ItemClick += Export;
            menu.AddItem(docxExport);

            //csv
            BarButtonItem csvExport = new BarButtonItem
            {
                Name = "csv",
                Caption = "Csv Dosyası(.csv)",
                ImageOptions = { Image = Properties.Resources.csv }

            };
            csvExport.ItemClick += Export;
            menu.AddItem(csvExport);
        }

        private void Export(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = $"{e.Item.Caption}|*.{e.Item.Name}";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (e.Item.Name)
                {
                    case "pdf":
                        _grid.ExportToPdf(dialog.FileName);
                        break;
                    case "xlsx":
                        _grid.ExportToXlsx(dialog.FileName);
                        break;
                    case "xls":
                        _grid.ExportToXls(dialog.FileName);
                        break;
                    case "html":
                        _grid.ExportToHtml(dialog.FileName);
                        break;
                    case "mht":
                        _grid.ExportToMht(dialog.FileName);
                        break;
                    case "rtf":
                        _grid.ExportToRtf(dialog.FileName);
                        break;
                    case "txt":
                        _grid.ExportToText(dialog.FileName);
                        break;
                    case "docx":
                        _grid.ExportToDocx(dialog.FileName);
                        break;
                    case "csv":
                        _grid.ExportToCsv(dialog.FileName);
                        break;
                }
            }
        }
    }
}
