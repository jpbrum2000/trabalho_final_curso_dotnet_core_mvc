using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SakilaWeb.Security;

namespace SakilaWeb.DB
{
    public class SakilaWebDbContext : IdentityDbContext<ApplicationUser> {
        public SakilaWebDbContext(DbContextOptions options) :
        base(options){ }
    }
}
