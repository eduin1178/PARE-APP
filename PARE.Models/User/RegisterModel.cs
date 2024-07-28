using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class RegisterModel
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public int UsersStatus { get; set; } = 1;
    }
}
