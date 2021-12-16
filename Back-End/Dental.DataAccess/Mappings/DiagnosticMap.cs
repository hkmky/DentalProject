using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class DiagnosticMap : EntityTypeConfiguration<Diagnostic>
    {
        public DiagnosticMap()
        {
            ToTable("Diagnostics");
            Property(c => c.DoctorId).HasColumnName("DoctorId");
            Property(c => c.ImageId).HasColumnName("ImageId");
            Property(c => c.PatientId).HasColumnName("PatientId");
        }
    }
}
