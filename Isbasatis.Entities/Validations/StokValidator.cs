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
   public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez.").Length(5,50).WithMessage("Stok Adı Alanı 5 ile 50 Karekter Arasında Olabilir.");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod Alanı Boş Geçilemez");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 1 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 2 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 3 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 1 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 2 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 3 Alanı 0'dan Küçük Olamaz.");
            RuleFor(p => p.StokKodu).IsUnique();
            RuleFor(p => p.Barkod).IsUnique();
        }
    }
}
