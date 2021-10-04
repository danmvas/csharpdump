using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        public string NameUser { get; set; }
        public string Surname { get; set; }
        public string Passport { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }

    }
}
