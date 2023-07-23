using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Ward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public string ward_Id { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        public string wardName { get; set;}

        public District district { get; set; }
    }
}
