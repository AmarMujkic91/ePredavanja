using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class eGostujucaPredavanjaContext : DbContext
    {
        public eGostujucaPredavanjaContext()
        {
        }

        public eGostujucaPredavanjaContext(DbContextOptions<eGostujucaPredavanjaContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventSponsors> EventSponsors { get; set; }
        public virtual DbSet<EventTypes> EventTypes { get; set; }
        public virtual DbSet<JobAppliations> JobAppliations { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<SessionSpeakers> SessionSpeakers { get; set; }
        public virtual DbSet<Speakers> Speakers { get; set; }
        public virtual DbSet<Sponsors> Sponsors { get; set; }
        public virtual DbSet<UserEvents> UserEvents { get; set; }
        public virtual DbSet<UserPositions> UserPositions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSessions> UserSessions { get; set; }
    }
}
