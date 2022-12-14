using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<Anasayfa> AnasayfaDbSet { get; set; }
        public DbSet<Blog> BlogDbSet { get; set; }
        public DbSet<Doktorlar> DoktorlarDbSet { get; set; }
        public DbSet<Hakkinda> HakkindaDbSet { get; set; }
        public DbSet<Iletisim> IletisimDbSet { get; set; }
        public DbSet<Randevu> RandevuDbSet { get; set; }
        public DbSet<Yorum> YorumDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=HastaneNetCoreIdent;integrated security=true");
        }
    }
}
