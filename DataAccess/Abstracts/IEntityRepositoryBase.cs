using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IEntityRepositoryBase<T> where T : class, IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filtre verilmeyebilir, opsiyona göre değişir
        T Get(Expression<Func<T,bool>> filter);//Linq yazmamıza olanak sağlar , filtre verilmesi zorunludur.
    }
}
