using DataAccess.Abstracts;
using Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfEntityRepositoryBase<T> : IEntityRepositoryBase<T> where T :class,IEntity,new()
    {
        public void Add(T entity)
        {
            using(CaseContext context = new CaseContext())
            {
                var AddedTEntity = context.Entry(entity);
                AddedTEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using( CaseContext context = new CaseContext())
            {
                var DeletedTEntity = context.Entry(entity);
                DeletedTEntity.State = EntityState.Deleted;
                context.SaveChanges();
            } 
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using(CaseContext context = new CaseContext())
            {
                //return context.Set<T>().Find(filter);
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using(CaseContext contex = new CaseContext())
            {
                return
                    filter == null ?
                    contex.Set<T>().ToList() :
                    contex.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using(CaseContext context = new CaseContext()){
                var UpdatedTEntity = context.Entry(entity);
                UpdatedTEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
