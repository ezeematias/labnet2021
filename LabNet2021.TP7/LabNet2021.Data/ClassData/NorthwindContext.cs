using LabNet2021.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LabNet2021.Data
{
    public partial class NorthwindContext : DbContext
    {

        public NorthwindContext() : base("name=NorthwindConnection") { }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { }
    }
}
