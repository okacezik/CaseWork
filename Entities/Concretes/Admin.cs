using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string Username { get; set; }
        public string AdminPassword { get; set; }
    }
}
