using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Mappings
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap()
        {
            //HaPrecision ile şunu ifade etmiş oluyouruz. 99999.99 degerden fazla girilemez.
            Property(c => c.Quantity).HasPrecision(7, 2);
            ToTable("Patients");
            Property(c => c.Quantity).HasColumnName("Quantity");
            Property(c => c.Total).HasColumnName("Total");
            Property(c => c.PaymentType).HasColumnName("PaymentType");
        }
    }
}
