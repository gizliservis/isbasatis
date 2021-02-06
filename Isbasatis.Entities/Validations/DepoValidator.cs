using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using Isbasatis.Entities.Context;
using Isbasatis.Entities.Extensions.FluentValidation;
using Isbasatis.Entities.Tables;

namespace Isbasatis.Entities.Validations
{
   public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Boş Geçilemez");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Boş Geçilemez");
            RuleFor(p => p.DepoKodu).IsUnique();
        }

   
    }
}
