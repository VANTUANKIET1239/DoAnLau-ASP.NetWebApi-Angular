using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Promotion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Promotion_Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string PromotionName { get; set; }


        [Column(TypeName = "varchar(80)")]
        public string ValidityPeriod { get; set; }



        public DateTime ExpirationDate { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string PromotionDetails { get; set; }


        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public  ICollection<PromotionBranch> PromotionBranches { get; set; }
        public ICollection<PromotionUser> PromotionUsers { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}
