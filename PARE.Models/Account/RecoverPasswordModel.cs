using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class RecoverPasswordModel
    {
        public string EmailOrPhoneNumber { get; set; }
        public bool SendEmail { get; set; } = true;
        public bool SendWhatsApp { get; set; } = true;
        public bool SendSms { get; set; } = true;
    }
}
