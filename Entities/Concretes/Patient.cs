using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Patient : IEntity
    {
        public int PatientId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isSick { get; set; }
        public DateTime CaseDate 
        {
            get { return CaseDate; }
            set { CaseDate = DateTime.Now; } 
        }
    }
}
