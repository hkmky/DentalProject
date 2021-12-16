using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.DataAccess.Dals.Base;
using Dental.DataAccess.Interface;
using Dental.DataAccess.Interface.Base;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Dals
{
    public class DiagnosticDal : Repository<Diagnostic>,IDiagnosticDal
    {
        public DiagnosticDal(DbContext context) : base(context)
        {
        }
    }
}
