using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class ReservationTimeDTO
    {
       
        public string reservationTime_Id { get; set; }

      
        public TimeSpan Time { get; set; }

        public bool state { get; set; }

      
    }
}
