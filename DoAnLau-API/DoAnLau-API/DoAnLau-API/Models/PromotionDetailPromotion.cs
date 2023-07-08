namespace DoAnLau_API.Models
{
    public class PromotionDetailPromotion
    {
        public string promotion_Id { get; set; }

        public string promotionDetail_Id { get; set; }

        public Promotion promotion { get; set; }

        public PromotionDetail promotionDetail { get; set; }
    }
}
