using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Registration.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set;}
            [Required ]
            [Column ("TypeName = nvarchar (250)")]
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";

        }
    }

