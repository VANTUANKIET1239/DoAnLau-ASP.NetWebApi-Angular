using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class OrderDTO
    {
      
        public string order_Id { get; set; }

        public DateTime orderDate { get; set; }

        public int totalPrice { get; set; }
       
        public string Note { get; set; }
        
        public string paymentMethod { get; set; }
    }
}
