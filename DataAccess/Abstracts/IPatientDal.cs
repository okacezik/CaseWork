using Entities.Concretes;
using Entities.Concretes.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IPatientDal : IEntityRepositoryBase<Patient>
    {
        bool ExistPatient(string identityNumber);
        List<PatientDetailDto> GetAllPatientsDetails();
    }
}
