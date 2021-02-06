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
   public class FisValidator:AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.FisKodu).IsUnique();
            
        }
    }
}
