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
            //this.Addresses = new HashSet<Address>();
        }
        [Key]
        public int userId { get; set; }

        //[Required(ErrorMessage = "First Name is required")]
        //[StringLength(20, ErrorMessage = "First Name cannot exceed 20 characters")]
        //[RegularExpression(@"^[\u0621-\u064A\u0660-\u0669 ]+$")]
        [Required()]
        [StringLength(20)]
        public string fristName { get; set; }
        //[StringLength(40, ErrorMessage = "Middel Name cannot exceed 20 characters")]
        // [RegularExpression(@"^[\u0621-\u064A\u0660-\u0669 ]+$")]
        public string? middelName { get; set; }
        //[Required(ErrorMessage = "Last Name is required")]
        //[StringLength(20, ErrorMessage = "Last Name cannot exceed 20 characters")]
        //[RegularExpression(@"^[\u0621-\u064A\u0660-\u0669 ]+$")]
        [Required()]
        [StringLength(20)]
        public string lastName { get; set; }

        //[Required(ErrorMessage = "Brith Date is required")]
        //check that min age =20
        [Required()]
        public DateTime brithDate { get; set; }

        //[Required(ErrorMessage = "Mobile Number is required")]
        //check is number belong to task ==> format
        [Required()]
        public String mobileNumber { get; set; }

        //[Required(ErrorMessage = "Email is required")]
        //check is mail
        //[RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)]
        [Required()]
        public String email { get; set; }

        public virtual ICollection<Address>? Addresses { get; set; }

    }

}
