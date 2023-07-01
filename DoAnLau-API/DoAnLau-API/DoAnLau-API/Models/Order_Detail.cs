using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Order_Detail
    {      
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public  string OrderDetail_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string Order_Id { get; set; }


        [Column(TypeName = "nvarchar(200)")]
        public string MenuName { get; set; }


        [Column(TypeName = "varchar(300)")]
        public string MenuImage { get; set; }


        public int Price { get; set; }


        public int Quantity { get; set; }


        public int MenuTotalPrice { get; set; }

        public Order Order { get; set; }
    }
}
