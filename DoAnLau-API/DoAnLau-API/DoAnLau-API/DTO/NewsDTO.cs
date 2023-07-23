using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Interface
{
    public class NewsDTO
    {    
        public string news_Id { get; set; }
       
        public string title { get; set; }
       
        public string content { get; set; }

        public DateTime PostDate { get; set; }

        public bool state { get; set; }
    }
}
