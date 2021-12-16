using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            Property(c => c.FirstName).HasMaxLength(30);
            Property(c => c.LastName).HasMaxLength(30);
            Property(c => c.UserName).HasMaxLength(30);
            Property(c => c.Email).HasMaxLength(30);
            ToTable("Users");
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.LastName).HasColumnName("LastName");
            Property(c => c.UserName).HasColumnName("UserName");
            Property(c => c.Password).HasColumnName("Password");
            Property(c => c.Email).HasColumnName("Email");
        }
    }
}
