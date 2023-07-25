using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class MenuDTO
    {
        public string menu_Id { get; set; }
      
        public string menuName { get; set; }
    
        public string menuImage { get; set; }
        public int price { get; set; }
       
        public bool hotDeal { get; set; }
    
        public bool bestSaller { get; set; }

        public bool state { get; set; }

        
    }
}
