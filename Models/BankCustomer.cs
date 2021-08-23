using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Models
{
    public class BankCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is Required")]
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Address")]

        public string Address { get; set; }


        [DisplayName("Age")]

        public int Age { get; set; }
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Gender")]

        public string Gender { get; set; }
        [Column(TypeName ="varchar(100)")]
        [DisplayName("Opening Balance")]

        public string OpeningBalance { get; set; }




    }
}
