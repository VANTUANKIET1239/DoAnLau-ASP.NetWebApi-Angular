using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class PromotionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
   
        public string promotionDetail_Id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string content { get; set; }

        public ICollection<PromotionDetailPromotion> promotionDetailPromotions { get; set; }
    }
}
