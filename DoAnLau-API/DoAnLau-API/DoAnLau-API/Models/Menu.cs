using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
     
        public string menu_Id { get; set; }
        [Column( TypeName = "nvarchar(200)")]
        public string menuName { get; set; }
        [Column(TypeName = "varchar(400)")]
        public string menuImage { get; set; }
        public int price { get; set; }
        [Column(TypeName = "bit")]
        public bool hotDeal { get; set; }
        [Column(TypeName = "bit")]
        public bool bestSaller { get; set; }
        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public MenuCategory menuCategory { get; set; }

        public ICollection<Order_Detail> order_Details { get; set; }

    }
}
