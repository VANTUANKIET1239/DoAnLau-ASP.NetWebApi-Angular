using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class CustomerSize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string customerSize_Id { get; set; }


        public int size { get; set; }

        public bool state { get; set; }

        public ICollection<Reservation> reservations { get; set; }
    }
}
