using Isbasatis.Entities.Context;
using Isbasatis.Entities.RepoSitories;
using Isbasatis.Entities.Tables;
using Isbasatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Data_Access
{
   public class BankaHareketDAL: EntityRepoSitoryBase<IsbaSatisContext, BankaHareket, BankaHareketValidator>
    {
    }
}
