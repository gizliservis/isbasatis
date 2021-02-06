using FluentValidation;
using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Extensions.FluentValidation
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<TEntity,object> IsUnique <TEntity>(this IRuleBuilder<TEntity, object> ruleBuilder)
            where TEntity : class, IEntity, new()
        {
            return ruleBuilder.SetValidator(new UniqueValidator<TEntity>());
        }
    }
}
