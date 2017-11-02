using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace YouthFuturesShelterHome.Models
{
    public class CMSDBDataContext : DbContext
    {
        public DbSet<ServiceContent> Services { get; set; }
        public DbSet<VoulnteerContent> Voulnteers { get; set; }
        public DbSet<TitelHeader> TitleHeaders { get; set; }
    }

}
