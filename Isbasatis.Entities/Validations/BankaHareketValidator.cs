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
            RuleFor(p => p.Hareket).NotEmpty().WithMessage("İşlem Türü Alanı Boş Geçilemez !!!");
            RuleFor(p => p.FisKodu).NotEmpty().WithMessage("Fiş Kodu Alanı Boş Geçilemez!!!");
            RuleFor(p => p.Banka.Bankasi).NotEmpty().WithMessage("Banka Adı Boş Geçilemez");
            RuleFor(p => p.Tarih).NotEmpty().WithMessage("Tarih Alanı Boş Geçilemez");

        }
    }
}
