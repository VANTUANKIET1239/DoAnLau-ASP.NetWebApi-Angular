using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class PromotionDetailDTO
    {
        
        public string promotionDetail_Id { get; set; }

     
        public string content { get; set; }

    }
}
