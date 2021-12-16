using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Business.Manager.Base;
using Dental.Business.Services;
using Dental.DataAccess.UnitOfWork;
using Dental.Entities.Tables;

namespace Dental.Business.Manager
{
    public class ToothManager : BaseManager<Tooth>,IToothService
    {
        public ToothManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
