using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public  string District_Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string DistrictName { get; set; }

        public City City { get; set; }

        public ICollection<Ward> Wards { get; set; }
    }
}
