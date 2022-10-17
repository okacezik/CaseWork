using Business.Abstracts;
using Business.BusinessRules;
using Business.Constants;
using Core.Utilites.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.Concretes;
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
            var result = PatientBusinessRules.ExistPatientControl(_patientDal, patient);
            if (result)
            {
                _patientDal.Delete(patient);
                return new SuccessResult(Messages.PatientDeleted);
            }
            return new ErrorResult(Messages.PatientNotFound);
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

        public IDataResult<List<PatientDetailDto>> GetAllPatientsDetails()
        {
            return new SuccessDataResult<List<PatientDetailDto>>
                (Messages.PatientsListed,_patientDal.GetAllPatientsDetails());
        }

        public IDataResult<List<Patient>> GetAllPositive()
        {
            return new SuccessDataResult<List<Patient>>
                (Messages.PatientsListed, _patientDal.GetAll(patient => patient.IsSick == true));
        }

        public IResult Update(Patient patient)
        {
            var result = PatientBusinessRules.ExistPatientControl(_patientDal, patient);
            if (result)
            {
                _patientDal.Update(patient);
                return new SuccessResult(Messages.PatientUpdated);
            }
            return new ErrorResult(Messages.PatientNotFound);
        }
    }
}
