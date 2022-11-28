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
using System.Web.Http.Cors;

namespace isbasatis.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")] // tune to your needs
    public class DataController : ApiController
    {

        [HttpGet]
        [Route("api/Data/StokListele")]
        public object StokListele()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            StokDAL stokDAL = new StokDAL();
            var stk = stokDAL.StokListele(context);
            return stk;

            //try
            //{
            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            //    IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            //    StokDAL stokDAL = new StokDAL();
            //    var stk = stokDAL.StokListele(context);
            //    return stk;
                
         

            //}
            //catch (Exception e)
            //{
            //    return e.Message;
            //}
    

        }
        [HttpGet]
        [Route("api/Data/StokListeleGrup")]
        public object StokListeleGrup(string grup)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            var stk = context.Stoklar.Where(c=>c.StokKodu==grup).Select(c=>c.StokAdi).ToList();
            return stk;


        }
        [HttpGet]
        [Route("api/Data/CariListele")]
        public object CariListele()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            CariDAL cariDal = new CariDAL();
            var cari = cariDal.CariListele(context);
            return cari;

        }

        //[HttpGet]
        //[Route("api/Data/StokListeleFilter")]
        //public object StokListeleFilter(Stok stok)
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
        //    IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
        //    StokDAL stokDAL = new StokDAL();
        //    var stk = stokDAL.StokListeleFilter(context,stok);
        //    return stk;

        //}
        [HttpPost]
        [Route("api/Data/StokEkle")]
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
        [HttpPost]
        [Route("api/Data/CariEkle")]
        public void CariEkle(Cari stk)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            using (var db = new IsbaSatisContext(con.ConnectionString))
            {
                db.Cariler.Add(new Cari
                {
                    
                    CariKodu = stk.CariKodu,
                    CariAdi = stk.CariAdi,
                    FaturaUnvani = stk.FaturaUnvani,
                    CariGrubu = stk.CariGrubu,
                    CariTuru = stk.CariTuru,
                    Il = stk.Il,
                    Ilce = stk.Ilce,
                    Adres = stk.Adres

                });
                db.SaveChanges();

            }
        }
        [HttpPost]
        [Route("api/Data/StokSil")]
        public void StokSil(Stok stok)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            StokDAL stokDal = new StokDAL();
            stokDal.Delete(context, c => c.Id == stok.Id);
            stokDal.Save(context);
        }
        [HttpPost]
        [Route("api/Data/CariSil")]
        public void CariSil(Cari cari)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            CariDAL cariDal = new CariDAL();
            cariDal.Delete(context, c => c.Id == cari.Id);
            cariDal.Save(context);
        }
        [HttpPost]
        [Route("api/Data/StokUpdate")]
        public void StokUpdate(Stok stok)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IsbaSatisContext"].ConnectionString);
            IsbaSatisContext context = new IsbaSatisContext(con.ConnectionString);
            StokDAL stokDal = new StokDAL();
            stokDal.AddOrUpdate(context, stok);
            stokDal.Save(context);
        }

    }
}
