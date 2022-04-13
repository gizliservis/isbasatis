using Isbasatis.Entities.Context;
using System.Data.Entity.Migrations;
using Isbasatis.Entities.Tables;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;

namespace Isbasatis.Entities.Interfaces
{
    public interface IEntityRepoSitory<TContext,TEntity> : IDisposable
        where TContext:DbContext,new()
        where TEntity:class,IEntity,new()
    {
         bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context); 
      
    }
}
