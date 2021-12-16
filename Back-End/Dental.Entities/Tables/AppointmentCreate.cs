using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class AppointmentCreate : EntityBase
    {
        public Guid AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
