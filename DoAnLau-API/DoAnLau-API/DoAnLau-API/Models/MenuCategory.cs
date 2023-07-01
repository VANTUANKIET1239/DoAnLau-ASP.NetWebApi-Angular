using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class MenuCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string MenuCategory_Id {  get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}
