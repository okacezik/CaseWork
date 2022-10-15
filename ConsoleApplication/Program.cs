using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatientTest();
        }

        private static void PatientTest()
        {
            IPatientService patientService = new PatientManager(new EfPatientDal());

            foreach (var patient in patientService.GetAll().Data)
            {
                Console.WriteLine(patient.FirstName);
            }
        }
    }
}