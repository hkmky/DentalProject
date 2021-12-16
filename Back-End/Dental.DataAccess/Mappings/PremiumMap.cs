using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class PremiumMap : EntityTypeConfiguration<Premium>
    {
        public PremiumMap()
        {
            Property(c => c.Percent).HasPrecision(5, 2);
            ToTable("Premiums");
            Property(c => c.DiagnosticId).HasColumnName("DiagnosticId");
            Property(c => c.DoctorId).HasColumnName("DoctorId");
            Property(c => c.Percent).HasColumnName("Percent");
        }
    }
}
