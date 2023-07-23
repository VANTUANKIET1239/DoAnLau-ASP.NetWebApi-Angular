using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnLau_API.Models
{
    public class Order_Detail
    {      
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
      
        public  string orderDetail_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
     
        public string order_Id { get; set; }

        /*[Column(TypeName = "nvarchar(200)")]
        public string menuName { get; set; }


        [Column(TypeName = "varchar(300)")]
        public string menuImage { get; set; }*/

        public int price { get; set; }


        public int quantity { get; set; }


        public int menuTotalPrice { get; set; }

        public Order order { get; set; }

        public Menu menu { get; set; }
    }
}
