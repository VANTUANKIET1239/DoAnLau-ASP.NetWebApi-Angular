using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class AddressDTO
    {
       
        public string address_Id { get; set; }
       
        public string name { get; set; }
        
        public string phone { get; set; }

        public string email { get; set; }
        
        public string addressDetail { get; set; }
        
        public string ward { get; set; }
       
        public string district { get; set; }
     
        public string city { get; set; }
      
        public bool isDefault { get; set; }
       
        public bool state { get; set; }
    }
}
