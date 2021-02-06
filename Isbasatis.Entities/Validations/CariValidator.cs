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
   public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez.").Length(5, 50).WithMessage("Cari Adı Alanı 5 ile 50 Karekter Arasında Olabilir.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi Alanı Boş Geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz Email Geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı 0'dan Küçük Olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti 0'dan Küçük Olamaz.");
            RuleFor(p => p.CariKodu).IsUnique();



        }
    }
}
