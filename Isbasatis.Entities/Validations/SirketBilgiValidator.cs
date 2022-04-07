using FluentValidation;
using Isbasatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Validations
{
   public class SirketBilgiValidator : AbstractValidator<SirketBilgi>
    {
        public SirketBilgiValidator()
        {
            RuleFor(p => p.SirketKodu).NotEmpty().WithMessage("Şirket Kodu Alanı Boş Geçilemez !!!");
            RuleFor(p => p.SirketUnvani).NotEmpty().WithMessage("Şirket Unvanı Alanı Boş Geçilemez !!!").MaximumLength(150).WithMessage("Şirlet Unvanı Alanı 5 ile 150 Karekter Arasında Olabilir.");
            RuleFor(p => p.SirketKisaAdi).NotEmpty().WithMessage("Şirket KısaAdı Alanı Boş Geçilemez !!!").MaximumLength(50).WithMessage("Şirket KısaAdı Alanı 5 ile 50 Karekter Arasında Olabilir.");
            RuleFor(p => p.VergiDairesi).MaximumLength(11).WithMessage("Lütfen Vergi Dairesi Alanına En Fazla 11 Hane Griniz");
            RuleFor(p => p.SirketTelNo).MaximumLength(11).WithMessage("Lütfen Telefon No Alanına En Fazla 11 Hane Griniz");


        }
    }
}
