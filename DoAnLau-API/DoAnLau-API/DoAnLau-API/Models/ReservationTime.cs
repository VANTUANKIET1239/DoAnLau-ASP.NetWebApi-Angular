using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class ReservationTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string reservationTime_Id { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        public bool state { get; set; }

        public ICollection<Reservation> reservations { get; set; }

        public ICollection<BranchReservationTime> branchReservationTimes { get; set; }
    }
}
