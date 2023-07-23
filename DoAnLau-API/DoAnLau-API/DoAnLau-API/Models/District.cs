using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public  string district_Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string districtName { get; set; }

        public City city { get; set; }

        public ICollection<Ward> wards { get; set; }
    }
}
