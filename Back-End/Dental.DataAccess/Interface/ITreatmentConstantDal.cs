using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.DataAccess.Interface.Base;
using Dental.Entities.Tables;

namespace Dental.DataAccess.Interface
{
    public interface ITreatmentConstantDal : IRepository<TreatmentConstant>
    {
    }
}
