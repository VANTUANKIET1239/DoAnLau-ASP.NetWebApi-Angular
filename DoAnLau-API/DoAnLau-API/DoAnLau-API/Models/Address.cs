using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Address_Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = " varchar(15)")]
        public string Phone { get; set; }

        [Column(TypeName = " varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string AddressDetail { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Ward { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string District { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }
        [Column(TypeName = "bit")]
        public bool IsDefault { get; set; }
        [Column(TypeName = "bit")]
        public  bool State { get; set; }
        public User User { get; set; }
    }
}
