using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string City_Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string CityName { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
