using FluentValidation;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Validations
{
    public class BankaHareketValidator : AbstractValidator<BankaHareket>
    {
        public BankaHareketValidator()
        {
            RuleFor(p => p.Hareket).NotEmpty().WithMessage("Hesap Kodu Alanı Boş Geçilemez !!!");
        }
    }
}
