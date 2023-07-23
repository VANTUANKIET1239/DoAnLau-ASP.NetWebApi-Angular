using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class BranchReservationTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public string branch_Id { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
  

        public string reservationTime_Id { get; set;}

        public Branch branch { get; set;}

        public ReservationTime reservationTime { get; set; }
    }
}
