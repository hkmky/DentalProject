using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class AppointmentCreateMap : EntityTypeConfiguration<AppointmentCreate>
    {
        public AppointmentCreateMap()
        {
            ToTable("AppointmentCreates");
            Property(c => c.AppointmentId).HasColumnName("AppointmentId");
            Property(c => c.PatientId).HasColumnName("PatientId");
        }
    }
}
