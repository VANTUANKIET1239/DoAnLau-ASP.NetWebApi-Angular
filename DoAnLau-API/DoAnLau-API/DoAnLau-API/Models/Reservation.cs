using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        public string reservation_Id { get; set; }

        public DateTime ReservationDate { get; set; }
/*
        [Column(TypeName = "time")]
        public TimeSpan reservationTime { get; set; }*/

        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public ICollection<ReservationUser> reservationUsers { get; set; }

        public Branch branch { get; set; }

        public CustomerSize customerSize { get; set; }

        public ReservationTime reservationTime { get; set; }
    }
}
