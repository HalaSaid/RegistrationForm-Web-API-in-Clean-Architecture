using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Domain.Entities
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        public string cityName { get; set; }
        public int governmentId { get; set; }
        public Government? Government { get; set; }

    }
}
