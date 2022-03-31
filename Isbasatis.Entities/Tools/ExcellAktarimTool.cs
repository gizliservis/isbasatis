using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isbasatis.Entities.Tools
{
   public class ExcellAktarimTool
    {
        public DataTable ExcellAktar(string sheetName)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";
            file.ShowDialog();
            string tamYol = file.FileName;

            string baglantiAdresi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tamYol + ";Extended Properties='Excel 12.0;IMEX=1;'";

            //bağlantı 
            OleDbConnection baglanti = new OleDbConnection(baglantiAdresi);
            //tüm verileri seçmek için select sorgumuz. Sayfa1 olan kısmı Excel'de hangi sayfayı açmak istiyosanız orayı yazabilirsiniz.
            OleDbCommand komut = new OleDbCommand(string.Format("Select * from [{0}" + "$" + "]", sheetName), baglanti);
            //bağlantıyı açıyoruz.
            baglanti.Open();
            //Gelen verileri DataAdapter'e atıyoruz.
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            //Grid'imiz için bir DataTable oluşturuyoruz.
            DataTable data = new DataTable();
            //DataAdapter'da ki verileri data adındaki DataTable'a dolduruyoruz.
            da.Fill(data);
            //DataGrid'imizin kaynağını oluşturduğumuz DataTable ile dolduruyoruz.
            return data;
        }
    }
}
