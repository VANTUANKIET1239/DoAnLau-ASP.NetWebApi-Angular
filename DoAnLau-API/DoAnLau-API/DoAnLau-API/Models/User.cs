using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nchar(5)")]
        public string User_Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }


        [Column(TypeName = " varchar(100)")]
        public string Email { get; set; }


        public DateTime BirthDate { get; set; }


        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

        public int RewardPoints { get; set; }


        [Column(TypeName = "bit")]
        public bool Role { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; }

        public ICollection<PromotionUser> PromotionUsers { get; set; }
        public ICollection<ReservationUser> ReservationUsers { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
