using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Ward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Ward_Id { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        public string WardName { get; set;}

        public District District { get; set; }
    }
}
