using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections;


namespace RegistrationForm.Domain.Entities
{
    public class User
    {
        public User()
        {
            this.Addresses = new HashSet<Address>();
        }
        [Key]
        public int userId { get; set; }

        [Required()]
        [StringLength(20)]
        public string fristName { get; set; }
        public string? middelName { get; set; }

        [Required()]
        [StringLength(20)]
        public string lastName { get; set; }
        [Required()]
        public DateTime brithDate { get; set; }

        [Required()]
        public String mobileNumber { get; set; }

        [Required()]
        public String email { get; set; }

        public virtual ICollection<Address>? Addresses { get; set; }

    }

}
