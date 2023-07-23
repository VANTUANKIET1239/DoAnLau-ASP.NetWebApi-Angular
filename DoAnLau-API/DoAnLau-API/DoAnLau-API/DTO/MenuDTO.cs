using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class MenuDTO
    {
        public string nenu_Id { get; set; }
      
        public string nenuName { get; set; }
    
        public string nenuImage { get; set; }
        public int price { get; set; }
       
        public bool hotDeal { get; set; }
    
        public bool bestSaller { get; set; }

        public bool state { get; set; }

        
    }
}
