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
            using(EfCaseContext context = new EfCaseContext())
            {
                var AddedTEntity = context.Entry(entity);     
                AddedTEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using( EfCaseContext context = new EfCaseContext())
            {
                var DeletedTEntity = context.Entry(entity);   //referans yakalama işlemi
                DeletedTEntity.State = EntityState.Deleted;   //yakalanan referansın durumunu belirleme
                context.SaveChanges();                        //değişiklikler kaydedildi
            } 
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using(EfCaseContext context = new EfCaseContext())
            {
                //return context.Set<T>().Find(filter);
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using(EfCaseContext context = new EfCaseContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using(EfCaseContext context = new EfCaseContext()){
                var UpdatedTEntity = context.Entry(entity);
                UpdatedTEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
