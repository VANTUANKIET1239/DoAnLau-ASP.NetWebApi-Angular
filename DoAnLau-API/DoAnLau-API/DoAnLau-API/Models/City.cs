using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string city_Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string cityName { get; set; }

        public ICollection<District> districts { get; set; }
    }
}
