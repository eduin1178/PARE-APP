using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Sort { get; set; }
        public string PhoneCode { get; set; }
        public string Name { get; set; }
        public string UrlPictureFlag { get; set; }
        public int Departmens { get; set; }
        public int Cities { get; set; }
    }

}
