using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string branch_Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string branchName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string addressDetail { get; set; }
        [Column(TypeName = " nvarchar(20)")]
        public string ward { get; set; }
        [Column(TypeName = " nvarchar(20)")]
        public string district { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string city { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string phone { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string openingTime { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public ICollection<PromotionBranch> promotionBranches { get; set; }
        public ICollection<Reservation> reservations { get; set; }

        public ICollection<BranchReservationTime> branchReservationTimes { get; set; }
    }
}
