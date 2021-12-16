using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class ToothMap : EntityTypeConfiguration<Tooth>
    {
        public ToothMap()
        {
            Property(c => c.Name).HasMaxLength(50);
            ToTable("Teeth");
            Property(c => c.Name).HasColumnName("Name");
            Property(c => c.PatientId).HasColumnName("PatientId");
            Property(c => c.ToothImage).HasColumnName("ToothImage");
            
        }
    }
}
