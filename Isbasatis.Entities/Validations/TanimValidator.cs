using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Isbasatis.Entities.Tables;

namespace Isbasatis.Entities.Validations
{
   public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım TÜrü Adı Boş Geçilemez");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım Boş Geçilemez");
         
        }
    }
}
