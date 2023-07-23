using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Promotion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string promotion_Id { get; set; }


        [Column(TypeName = "varchar(300)")]
        public string PromotionImage { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string promotionName { get; set; }


        [Column(TypeName = "varchar(80)")]
        public string validityPeriod { get; set; }

        public DateTime expirationDate { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string promotionDetails { get; set; }


        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public  ICollection<PromotionBranch> promotionBranches { get; set; }
        public ICollection<PromotionUser> promotionUsers { get; set; }

        public ICollection<PromotionDetailPromotion> promotionDetailPromotions { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
