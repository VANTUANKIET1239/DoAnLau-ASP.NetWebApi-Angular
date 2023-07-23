using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class PromotionDTO
    {
     
        public string promotion_Id { get; set; }


        public string PromotionImage { get; set; }

      
        public string promotionName { get; set; }

       
        public string validityPeriod { get; set; }

        public DateTime expirationDate { get; set; }

       
        public string promotionDetails { get; set; }

       
        public bool state { get; set; }

    }
}
