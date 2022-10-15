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
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
               _patientDal = patientDal;
        }
        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult(Messages.PatientAdded);
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult(Messages.PatientDeleted);
        }

        public IDataResult<Patient> Get(int PatientId)
        {
            return new SuccessDataResult<Patient>
                (Messages.PatientListed,_patientDal.Get(patient => patient.PatientId == PatientId)); 
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>
                (Messages.PatientsListed, _patientDal.GetAll());
        }

        public IDataResult<List<Patient>> GetAllPositive()
        {
            return new SuccessDataResult<List<Patient>>
                (Messages.PatientsListed, _patientDal.GetAll(patient => patient.isSick == true));
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult(Messages.PatientUpdated);
        }
    }
}
