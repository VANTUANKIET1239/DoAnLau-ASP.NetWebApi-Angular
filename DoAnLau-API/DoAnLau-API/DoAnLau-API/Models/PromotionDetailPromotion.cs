using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class PromotionDetailPromotion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string promotion_Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public string promotionDetail_Id { get; set; }

        public Promotion promotion { get; set; }

        public PromotionDetail promotionDetail { get; set; }
    }
}
