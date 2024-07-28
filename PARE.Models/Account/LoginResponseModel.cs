using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class LoginResponseModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public CityModel City { get; set; }
        public string Email { get; set; }
        public bool EmailIsVerified { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberIsVerified { get; set; }
        public bool PhoneNumberIsWhatsApp { get; set; }
        public bool WhatsAppIsVerified { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public int UserStateId { get; set; }
        public string UserStateName { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpire { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
