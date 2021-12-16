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
    public class PremiumManager : BaseManager<Premium>,IPremiumService
    {
        public PremiumManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
