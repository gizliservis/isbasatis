using FluentValidation.Resources;
using FluentValidation.Validators;
using Isbasatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isbasatis.Entities.Interfaces;

namespace Isbasatis.Entities.Extensions.FluentValidation
{
    public class UniqueValidator<TEntity> : PropertyValidator
        where TEntity:class,IEntity,new()
    {

        public UniqueValidator() : base("Girdiğniz {PropertyName} Kayıtlarda Var.")
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            using (var isbaSatisContext=new IsbaSatisContext())
            {
                var dataId = context.Instance.GetType().GetProperty("Id").GetValue(context.Instance);
                var result = isbaSatisContext.Set<TEntity>().Where($"{context.PropertyName}==@0 And Id!=@1", context.PropertyValue,dataId).Any();
                return !result;
            }
        }
    }   
}
