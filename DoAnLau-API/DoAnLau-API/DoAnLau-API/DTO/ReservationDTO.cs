using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class ReservationDTO
    {
       
        public string reservation_Id { get; set; }

        public DateTime ReservationDate { get; set; }
             
        public bool state { get; set; }

       
    }
}
