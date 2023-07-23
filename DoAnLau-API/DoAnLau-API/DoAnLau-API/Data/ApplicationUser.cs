using DoAnLau_API.Models;
using Microsoft.AspNetCore.Identity;

namespace DoAnLau_API.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string name { get; set; }

        public byte[] userImage { get; set; } = null!;

        public DateTime birthdate { get; set; }

        public bool gender { get; set; }

        public int rewardPoints { get; set; } = 0;

        public ICollection<PromotionUser> promotionUsers { get; set; }
        public ICollection<ReservationUser> reservationUsers { get; set; }

        public ICollection<Order> orders { get; set; }

        public ICollection<Address> addresses { get; set; }
    }
}
