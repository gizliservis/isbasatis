using Isbasatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tables.Other_Tables
{
    public class CodeNumara
    {
        IsbaSatisContext context = new IsbaSatisContext();
        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from c in context.Cariler orderby c.Id descending select c).First().CariKodu);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }

        }
        public string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from c in context.Stoklar orderby c.Id descending select c).First().StokKodu);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }
          

        }
        public string FisKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from c in context.Fisler orderby c.Id descending select c).First().FisKodu);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }

        }
        public string OdemeKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from c in context.Fisler orderby c.Id descending select c).First().FisKodu);
                Numara++;
                string num =Numara.ToString().PadLeft(5, '0');
                return "Fi"+num;
            }
            catch (Exception)
            {

                return "Fi00001";
            }

        }

    }
}
