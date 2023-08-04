using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class MenuCategoryDTO
    {

        public string menuCategory_Id { get; set; }

        public string categoryName { get; set; }

        public bool state { get; set; }

    } 
}
