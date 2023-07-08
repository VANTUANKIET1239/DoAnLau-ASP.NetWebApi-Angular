using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string address_Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }
        [Column(TypeName = " varchar(15)")]
        public string phone { get; set; }

        [Column(TypeName = " varchar(100)")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string addressDetail { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ward { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string district { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string city { get; set; }
        [Column(TypeName = "bit")]
        public bool isDefault { get; set; }
        [Column(TypeName = "bit")]
        public  bool state { get; set; }
        public User user { get; set; }
    }
}
