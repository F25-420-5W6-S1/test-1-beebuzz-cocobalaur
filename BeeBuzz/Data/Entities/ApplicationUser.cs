using Microsoft.AspNetCore.Identity;

namespace BeeBuzz.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
     
        public Organization Organization { get; set; }
        public string Role{ get; set; }

    }
}
