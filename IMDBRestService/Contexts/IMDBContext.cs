using IMDBRestService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace IMDBRestService.Contexts
{
    public class IMDBContext : DbContext
    {
        public IMDBContext(DbContextOptions<IMDBContext> options) : base(options) { }
        public DbSet<NameBasic> NameBasicData { get; set; }
        public DbSet<TitleAkas> TitleAkasData { get; set; }
        public DbSet<TitleBasic> TitleBasicData { get; set; }
        public DbSet<TitleCrew> TitleCrewData { get; set; }
        public DbSet<TitlePrincipals> TitlePrincipalsData { get; set; }
    }
}
