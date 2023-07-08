using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string nenu_Id { get; set; }
        [Column( TypeName = "nvarchar(200)")]
        public string nenuName { get; set; }
        [Column(TypeName = "varchar(400)")]
        public string nenuImage { get; set; }
        public int price { get; set; }
        [Column(TypeName = "bit")]
        public bool hotDeal { get; set; }
        [Column(TypeName = "bit")]
        public bool bestSaller { get; set; }
        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public MenuCategory menuCategory { get; set; }

    }
}
