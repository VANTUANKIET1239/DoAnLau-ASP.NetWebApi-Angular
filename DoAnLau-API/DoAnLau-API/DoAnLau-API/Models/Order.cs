using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Order_Id { get; set; }

 
        public DateTime OrderDate { get; set; }

        public int TotalPrice { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string PaymentMethod { get; set; }
        public User User { get; set; }

        public Promotion Promotion { get; set; }

        public Order_Detail Order_Detail { get; set; }

    }
}
