using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Department
    {
        [Key]
        public int DepId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50,MinimumLength =10)]
        [Phone]
        public string Phone { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
