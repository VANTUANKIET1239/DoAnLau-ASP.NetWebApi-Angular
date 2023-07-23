using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DoAnLau_API.Data;

namespace DoAnLau_API.Models
{
    public class PromotionUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string promotion_Id { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string user_Id { get; set; }

        public bool state { get; set; }
        public Promotion promotion { get; set; }

        public ApplicationUser user { get; set; }
    }
}
