using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Appointment : EntityBase
    {
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<AppointmentCreate> AppointmentCreates { get; set; }

    }
}
