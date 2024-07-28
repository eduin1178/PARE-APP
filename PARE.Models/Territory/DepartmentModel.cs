using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARE.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public CountryModel Country { get; set; }
    }

    public class DepartmentCitiesModel
    {
        public int Id { get; set; }
        public int Sort { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public CountryModel Country { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
