using Isbasatis.LicenseManager.API.Data;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Isbasatis.LicenseManager.LicenseInformations.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Isbasatis.LicenseManager.LicenseInformations.Enums;
using System.Threading.Tasks;

namespace Isbasatis.LicenseManager.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private LicenseContext _context;
        public LicenseController(LicenseContext context)
        {
            _context = context;

        }
        [HttpGet]
        public string GetLicense(Guid id)
        {
            ApiResponseResult result = new ApiResponseResult();
            if (_context.Licenses.Any(c=>c.Id==id))
            {
                result.returnType = LicenseInformations.Enums.ReturnType.Confirm;
                result.Value = JsonConvert.SerializeObject(_context.Licenses.FirstOrDefault(c => c.Id == id));
                return EncrpytionTool.Encrypt(JsonConvert.SerializeObject(result));
            }
            else
            {
                result.returnType = ReturnType.Error;
                result.Value="Lisans Bulunamadı";
                return EncrpytionTool.Encrypt(JsonConvert.SerializeObject(result));
            }

            


        }
    }
}
