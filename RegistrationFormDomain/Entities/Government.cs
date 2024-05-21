using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Domain.Entities
{
    public class Government
    {
        [Key]
        public int governmentId { get; set; }
        public string governmentName { get; set; }

    }
}
