namespace LR.DataModel
{
    using DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    class CafeContext : DbContext
    {

        public CafeContext()
            : base("name=Cafe")
        {
        }

        public DbSet<Cafe> ListOfCafe { get; set; }

        public DbSet<CafeInfo> ListOfCafeInfo { get; set; }

    }
}