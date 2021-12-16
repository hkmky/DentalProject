using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.DataAccess.Contexts.Dental
{
    public class DentalConfiguration : DbMigrationsConfiguration<DentalContext>
    {
        public DentalConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
