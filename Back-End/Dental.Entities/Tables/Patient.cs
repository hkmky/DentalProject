using System.Collections.Generic;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Patient : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Tooth> Teeth { get; set; }
    }
}
