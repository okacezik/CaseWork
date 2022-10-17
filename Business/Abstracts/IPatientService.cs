using Core.Utilites.Results;
using Entities.Concretes;
using Entities.Concretes.Concretes;
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
        IDataResult<List<Patient>> GetAll();            //tüm hastaları listeler
        IDataResult<Patient> Get(int PatientId);        //id bilgisine göre hasta listeler
        IDataResult<List<Patient>> GetAllPositive();    //tüm pozitif vakalı hastaları listeler
        IDataResult<List<PatientDetailDto>> GetAllPatientsDetails();
    }
}
