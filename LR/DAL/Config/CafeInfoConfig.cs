using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.Config
{
    public class CafeInfoConfig : EntityTypeConfiguration<CafeInfo>
    {
        public CafeInfoConfig ()
        {
            this.ToTable ("CafeInfo");
        }
    }
}
