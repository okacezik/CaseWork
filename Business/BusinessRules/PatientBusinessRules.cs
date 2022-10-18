using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public static class PatientBusinessRules
    {
        public static bool ExistPatientControl(IPatientDal patientDal, string identityNumber)
        {
            return patientDal.ExistPatient(identityNumber);
        } 
    }
}
