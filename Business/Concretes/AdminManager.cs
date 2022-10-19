using Business.Abstracts;
using Business.Constants;
using Core.Utilites.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AdminManager : IAdminService
    {

        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult EntryControl(string username, string password)
        {
            List<Admin> admins = _adminDal.GetAll();
            foreach (Admin admin in admins)
            {
                if(admin.Username.Equals(username) && admin.AdminPassword.Equals(password))
                {
                    return new SuccessResult(Messages.WelcomeToTheSystem);
                }
            }
            return new ErrorResult("kullanıcı bulunamadı...");
        }

        public IDataResult<Admin> Get(int id)
        {
            return new SuccessDataResult<Admin>
                (Messages.PatientListed, _adminDal.Get(admin => admin.AdminId == id));
        }

        public IDataResult<List<Admin>> GetAll()
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetAll());
        }
    }
}
