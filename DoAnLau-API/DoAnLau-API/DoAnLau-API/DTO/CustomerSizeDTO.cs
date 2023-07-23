using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class CustomerSizeDTO
    {
        public string customerSize_Id { get; set; }

        public int size { get; set; }

        public bool state { get; set; }

    }
}
