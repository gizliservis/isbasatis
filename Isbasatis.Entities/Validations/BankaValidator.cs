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
   public class BankaValidator:AbstractValidator<Banka>
    {
        public BankaValidator()
        {
            RuleFor(p => p.HesapKodu).NotEmpty().WithMessage("Hesap Kodu Alanı Boş Geçilemez !!!");
            RuleFor(p => p.Bankasi).NotEmpty().WithMessage("Bankası Alanı Boş Geçilemez !!!");
            RuleFor(p => p.HesapIsmi).NotEmpty().WithMessage("Hesap İsmi Alanı Boş Geçilemez !!!").MaximumLength(50).WithMessage("Hesap İsmi Alanı 5 ile 50 Karekter Arasında Olabilir.");
            RuleFor(p => p.IbanNo).MaximumLength(24).WithMessage("Iban No 24 Karakterden Fazla Olamaz");
            RuleFor(p => p.HesapNo).MaximumLength(14).WithMessage("Hesap No 14 Karakterden Fazla Olamaz");
            RuleFor(p => p.YetkiliTelefonu).MaximumLength(11).WithMessage("Yetkili Telefonu 11 Karakterden Fazla Olamaz");
            RuleFor(p => p.HesapKodu).IsUnique();
        }
    }
}
