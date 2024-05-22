using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Domain.Entities
{
    public class Address
    {

        [Key]
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int GovernmentId { get; set; }
        
        
        [StringLength(200)]
        public string street { get; set; }
        public string buildingNumber { get; set; }
        public int flatNumber { get; set; }
        
        public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
        //[ForeignKey("CityId")]
        //public virtual City City { get; set; }
        //[ForeignKey("GovernmentId")]
        //public virtual Government Government { get; set; }

    }
}
