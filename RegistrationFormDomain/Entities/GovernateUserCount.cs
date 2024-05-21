using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Domain.Entities
{
    public class GovernateUserCount
    {
        [Key]
        public int governateUserCountId { get; set; }
        public int? governmentId { get; set; }
        public int Count { get; set; }
        [ForeignKey("governmentId")]
        public virtual Government Government { get; set; }
    }
}
