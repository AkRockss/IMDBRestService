using IMDBRestService.Models;
using Microsoft.EntityFrameworkCore;

namespace IMDBRestService.Contexts
{
    public class IMDBContext : DbContext
    {
        public IMDBContext(DbContextOptions<IMDBContext> options) : base(options) { }

        public DbSet<NameBasic> Name_Basic { get; set; }
        public DbSet<TitleAkas> Title_Akas { get; set; }
        public DbSet<TitleBasic> Title_Basic { get; set; }
        public DbSet<TitleCrew> Title_Crew { get; set; }
        public DbSet<TitlePrincipals> Title_Principals { get; set; }

    }

}
