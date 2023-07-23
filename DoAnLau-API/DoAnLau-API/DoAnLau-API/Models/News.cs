using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public string news_Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string title { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string content { get; set; }

        public DateTime PostDate { get; set; }

        public bool state { get; set; }
    }
}
