using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public CountryModel Country { get; set; }
        public DepartmentModel Department { get; set; }
        public int? Sort { get; set; }
        public string Name { get; set; }
    }
}
