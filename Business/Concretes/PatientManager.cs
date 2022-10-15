using Business.Abstracts;
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
            return new SuccessResult("Hasta sisteme eklendi...");
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult("Hasta sistemden silindi...");
        }

        public IDataResult<Patient> Get(int PatientId)
        {
            return new SuccessDataResult<Patient>
                (_patientDal.Get(patient => patient.PatientId == PatientId)); 
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>
                ("Hastalar listelendi...", _patientDal.GetAll());
        }

        public IDataResult<List<Patient>> GetAllPositive()
        {
            return new SuccessDataResult<List<Patient>>
                ("Hastalar listelendi...", _patientDal.GetAll(patient => patient.isSick == true));
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult("Hasta durum güncelleme işlemi başarılı...");
        }
    }
}
