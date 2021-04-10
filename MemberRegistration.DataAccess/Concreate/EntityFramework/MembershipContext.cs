using MemberRegistration.DataAccess.Concreate.EntityFramework.Mappings;
using MemberRegistration.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.DataAccess.Concreate.EntityFramework
{
    public class MembershipContext:DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }
        public DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
