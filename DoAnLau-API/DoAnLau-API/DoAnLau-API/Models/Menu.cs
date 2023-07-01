using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Menu_Id { get; set; }
        [Column( TypeName = "nvarchar(200)")]
        public string MenuName { get; set; }
        [Column(TypeName = "varchar(400)")]
        public string MenuImage { get; set; }
        public int Price { get; set; }
        [Column(TypeName = "bit")]
        public bool HotDeal { get; set; }
        [Column(TypeName = "bit")]
        public bool BestSaller { get; set; }
        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public MenuCategory MenuCategory { get; set; }

    }
}
