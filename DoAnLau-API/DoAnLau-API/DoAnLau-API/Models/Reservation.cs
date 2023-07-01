using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Reservation_Id { get; set; }

        public DateTime ReservationDate { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ReservationTime { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public ICollection<ReservationUser> ReservationUsers { get; set; }

        public Branch Branch { get; set; }
    }
}
