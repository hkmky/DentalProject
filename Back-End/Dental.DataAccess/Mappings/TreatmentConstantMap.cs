using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class TreatmentConstantMap : EntityTypeConfiguration<TreatmentConstant>
    {
        public TreatmentConstantMap()
        {
            Property(c => c.Name).HasMaxLength(50);
            Property(c => c.Fee).HasPrecision(7, 2);
            ToTable("TreatmentConstants");
            Property(c => c.Name).HasColumnName("Name");
            Property(c => c.Fee).HasColumnName("Fee");
            Property(c => c.Image).HasColumnName("Image");
        }
    }
}
