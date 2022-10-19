using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAdminService
    {
        IDataResult<Admin> Get(int id);
        IDataResult<List<Admin>> GetAll();
        IResult EntryControl(string username, string password);
    }
}
