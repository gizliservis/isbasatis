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
    public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.Adi).NotEmpty().WithMessage("Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.Soyadi).NotEmpty().WithMessage("Soyadı Alanı Boş Geçilemez.");
            RuleFor(p => p.Gorevi).NotEmpty().WithMessage("Gorevi Alanı Boş Geçilemez.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola Alanı Boş Geçilemez.");
            RuleFor(p => p.HatirlatmaSorusu).NotEmpty().WithMessage("HatirlatmaSorusu Alanı Boş Geçilemez.");
            RuleFor(p => p.Cevap).NotEmpty().WithMessage("Cevap Alanı Boş Geçilemez.");
            RuleFor(p => p.KullaniciAdi).IsUnique();

        }
    }
}
