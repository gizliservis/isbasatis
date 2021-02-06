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
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu Boş Geçilemez");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme TÜrü Adı Boş Geçilemez");
            RuleFor(p => p.OdemeTuruKodu).IsUnique();
            RuleFor(p => p.OdemeTuruAdi).IsUnique();
        }
    }
}
