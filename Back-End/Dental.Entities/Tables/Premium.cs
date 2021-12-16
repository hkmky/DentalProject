using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Premium : EntityBase
    {
        public decimal Percent { get; set; }
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public Guid DiagnosticId { get; set; }
        public virtual Diagnostic Diagnostic { get; set; }
    }
}
