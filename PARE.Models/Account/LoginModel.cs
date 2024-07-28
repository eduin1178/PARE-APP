using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class LoginModel
    {
        public string EmailOrPhoneNumber { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}
