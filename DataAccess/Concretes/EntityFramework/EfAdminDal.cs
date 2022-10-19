using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAdminDal : IAdminDal
    {
        public Admin Get(Expression<Func<Admin,bool>> filter)
        {
            using(EfCaseContext context = new EfCaseContext())
            {
                return context.Set<Admin>().SingleOrDefault(filter);
            }
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter)
        {
            using(EfCaseContext contex = new EfCaseContext())
            {
                return contex.Set<Admin>().ToList();
            }
        }
    }
}
