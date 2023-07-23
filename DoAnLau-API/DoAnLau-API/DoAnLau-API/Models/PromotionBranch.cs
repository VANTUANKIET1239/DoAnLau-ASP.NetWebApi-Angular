using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class PromotionBranch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string promotion_Id { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string branch_Id { get; set; }

        public bool state { get; set; }
        public Promotion promotion { get; set; }

        public Branch branch { get; set; }
    }
}
