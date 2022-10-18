using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfPatientDal : EfEntityRepositoryBase<Patient>, IPatientDal
    {
        public bool ExistPatient(string identityNumber)
        {
            using(EfCaseContext context = new EfCaseContext())
            {
                return context.Set<Patient>().Any(p => p.IdentityNumber.Equals(identityNumber));
            }
        }

        public List<PatientDetailDto> GetAllPatientsDetails()
        {
            using(EfCaseContext context = new EfCaseContext())
            {
                var result = from patient in context.Set<Patient>().ToList()
                             select new PatientDetailDto
                             {
                                 PatientId = patient.PatientId,
                                 IdentityNumber = patient.IdentityNumber,
                                 IsSick = patient.IsSick,
                                 CaseDate = patient.CaseDate
                             };
                return result.ToList();
            }
        }
    }
}
