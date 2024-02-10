using Microsoft.AspNetCore.Identity;

namespace MaTHeMaTIcTeaCHeR.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public int RoleId { get; set; }
    }
}
