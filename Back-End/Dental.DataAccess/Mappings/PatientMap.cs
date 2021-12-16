using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            Property(c => c.FirstName).HasMaxLength(30);
            Property(c => c.LastName).HasMaxLength(30);
            Property(c => c.Telephone).HasMaxLength(30);
            Property(c => c.Email).HasMaxLength(30);

            ToTable("Patients");
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.LastName).HasColumnName("FirstName");
            Property(c => c.Telephone).HasColumnName("FirstName");
            Property(c => c.Email).HasColumnName("FirstName");
        }
    }
}
