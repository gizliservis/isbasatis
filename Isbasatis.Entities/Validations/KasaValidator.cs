using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Isbasatis.Entities.Extensions.FluentValidation;
using Isbasatis.Entities.Tables;

namespace Isbasatis.Entities.Validations
{
   public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Boş Geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Adı Boş Geçilemez.");
            RuleFor(p => p.KasaKodu).IsUnique();
        }
    }
}
