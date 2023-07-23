using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DoAnLau_API.Data;

namespace DoAnLau_API.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string order_Id { get; set; }

 
        public DateTime orderDate { get; set; }

        public int totalPrice { get; set; }
        [Column(TypeName = "nvarchar(400)")]
        public string Note { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string paymentMethod { get; set; }
        public ApplicationUser user { get; set; }

        public Promotion promotion { get; set; }

        public Order_Detail order_Detail { get; set; }

    }
}
