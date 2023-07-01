using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Branch_Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string BranchName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string AddressDetail { get; set; }
        [Column(TypeName = " nvarchar(20)")]
        public string Ward { get; set; }
        [Column(TypeName = " nvarchar(20)")]
        public string District { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string OpeningTime { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public ICollection<PromotionBranch> PromotionBranches { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
