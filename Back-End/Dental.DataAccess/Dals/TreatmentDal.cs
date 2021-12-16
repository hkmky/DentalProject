using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.DataAccess.Dals.Base;
using Dental.DataAccess.Interface;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Dals
{
    public  class TreatmentDal : Repository<Treatment>,ITreatmentDal
    {
        public TreatmentDal(DbContext context) : base(context)
        {
        }
    }
}
