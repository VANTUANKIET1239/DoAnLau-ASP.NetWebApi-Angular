using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class MenuCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string menuCategory_Id {  get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string categoryName { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public ICollection<Menu> menus { get; set; }
    }
}
