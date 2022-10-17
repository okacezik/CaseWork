using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Concretes
{
    public class PatientDetailDto
    {
        public int PatientId { get; set; }
        public string IdentityNumber { get; set; }
        public bool IsSick { get; set; }
        public DateTime CaseDate { get; set; }
    }
}
