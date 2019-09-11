using Microsoft.AspNetCore.Identity;

namespace BethanysPieShop.Models
{
    public class IdentityUserExtended : IdentityUser
    {
        public string Company { get; set; }
        public string Slogan { get; set; }
    }
}
