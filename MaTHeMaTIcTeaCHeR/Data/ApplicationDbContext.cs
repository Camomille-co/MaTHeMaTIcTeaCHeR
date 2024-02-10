using MaTHeMaTIcTeaCHeR.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaTHeMaTIcTeaCHeR.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
