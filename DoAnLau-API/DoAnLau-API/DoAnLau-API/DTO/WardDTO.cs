using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class WardDTO
    {
        
        public string ward_Id { get; set; }
 
        public string wardName { get; set; }

    }
}
