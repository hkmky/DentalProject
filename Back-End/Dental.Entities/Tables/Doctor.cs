using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class Doctor : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }
        public virtual ICollection<Premium> Premiums { get; set; }
    }
}
