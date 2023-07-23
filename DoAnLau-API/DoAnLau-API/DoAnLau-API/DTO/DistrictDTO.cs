using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class DistrictDTO
    {
        
        public string district_Id { get; set; }

      
        public string districtName { get; set; }

    }
}
