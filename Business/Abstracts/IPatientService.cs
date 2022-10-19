using Core.Utilites.Results;
using Entities.Concretes;
using Entities.Concretes.DTOS;
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
        IResult Delete(string identityNumber);
        IDataResult<List<Patient>> GetAll();            //tüm hastaları listeler
        IDataResult<Patient> GetById(int PatientId);     //id bilgisine göre hasta listeler
        IDataResult<Patient> GetByIdentityNumber(string identityNumber);
        IDataResult<List<Patient>> GetAllPositive();    //tüm pozitif vakalı hastaları listeler
        IDataResult<List<PatientDetailDto>> GetAllPatientsDetails();
    }
}
