using Isbasatis.Entities.Context;
using Isbasatis.Entities.Data_Access;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace isbasatis.WebApi.Controllers
{

    public class DataController : ApiController
    {

        [HttpGet]

        public object StokListele()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            StokDAL stokDAL = new StokDAL();
            var stk = stokDAL.StokListele(context);
            return stk;

        }
        [HttpPost]
        public void StokEkle(Stok stk)
        {
            
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
                using (var db = new IsbaSatisContext(con.ConnectionString))
                {
                    db.Stoklar.Add(new Stok
                    {
                        Durumu = stk.Durumu,
                        StokKodu =stk.StokKodu,
                        StokAdi=stk.StokAdi,
                        Barkod=stk.Barkod,
                        SatisFiyati1=stk.SatisFiyati1,
                        AlisFiyati1=stk.AlisFiyati1,
                        AlisKdv=stk.AlisKdv,
                        SatisKdv=stk.SatisKdv,
                        Birimi=stk.Birimi
                       
                    });
                    db.SaveChanges();
                    
                }
        }
        public void StokSil(Stok stok)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            StokDAL stokDal = new StokDAL();
            StokDAL.Delete(context,stok,c);
        }

    }
}
