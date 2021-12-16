using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class AppointmentMap : EntityTypeConfiguration<Appointment>
    {
        public AppointmentMap()
        {
            ToTable("Appointments");
            Property(c => c.PatientId).HasColumnName("PatientId");
        }
    }
}
