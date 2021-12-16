using System;
using System.Collections.Generic;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Diagnostic : EntityBase
    {
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public Guid ImageId { get; set; }
        public virtual Image Image { get; set; }
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Premium> Premiums { get; set; }
    }
}
