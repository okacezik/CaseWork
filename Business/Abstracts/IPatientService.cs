using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPatientService
    {
        IResult Add(Patient patient);
        IResult Update(Patient patient);
        IResult Delete(Patient patient);
        IDataResult<List<Patient>> GetAll();
        IDataResult<Patient> Get(int PatientId);
        IDataResult<List<Patient>> GetAllPositive();
    }
}
