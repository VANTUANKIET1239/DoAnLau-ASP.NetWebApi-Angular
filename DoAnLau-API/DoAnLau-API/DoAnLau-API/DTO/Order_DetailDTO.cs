using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Interface
{
    public class Order_DetailDTO
    {
      
        public string orderDetail_Id { get; set; }

        public string order_Id { get; set; }


        public int price { get; set; }


        public int quantity { get; set; }


        public int menuTotalPrice { get; set; }

     
    }
}
