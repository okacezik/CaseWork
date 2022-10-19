using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IAdminDal
    {
       Admin Get(Expression<Func<Admin,bool>> filter);
       List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null); 
    }
}
