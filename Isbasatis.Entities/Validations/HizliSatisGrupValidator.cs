using FluentValidation;
using Isbasatis.Entities.Extensions.FluentValidation;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Validations
{
   public class HizliSatisGrupValidator:AbstractValidator<HizliSatisGrup>
    {
        public HizliSatisGrupValidator()
        {
            RuleFor(p => p.GrupAdi).IsUnique();
        }
    }
}
