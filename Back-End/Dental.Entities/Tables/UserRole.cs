using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Enums;
using Dental.Entities.Tables.Base;

namespace Dental.Entities.Tables
{
    public class UserRole : EntityBase
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public JobConstant JobConstant { get; set; }
    }
}
