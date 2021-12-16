using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Core.Functions;
using Dental.DataAccess.Contexts.Dental;
using Dental.DataAccess.Dals;
using Dental.DataAccess.Dals.Base;
using Dental.DataAccess.Interface;
using Dental.DataAccess.Interface.Base;

namespace Dental.DataAccess.UnitOfWork
{
    public class DentalUnitOfWork : IUnitOfWork
    {
        private readonly DentalContext _context;
        public IAppointmentDal AppointmentDal { get; set; }
        public IAppointmentCreateDal AppointmentCreateDal { get; set; }
        public IDiagnosticDal DiagnosticDal { get; set; }
        public IDoctorDal DoctorDal { get; set; }
        public IExpenseDal ExpenseDal { get; set; }
        public IImageDal ImageDal { get; set; }
        public IPatientDal PatientDal { get; set; }
        public IPaymentDal PaymentDal { get; set; }
        public IPremiumDal PremiumDal { get; set; }
        public IToothDal ToothDal { get; set; }
        public ITreatmentConstantDal TreatmentConstantDal { get; set; }
        public ITreatmentDal TreatmentDal { get; set; }
        public IUserDal UserDal { get; set; }
        public IUserRoleDal UserRoleDal { get; set; }

        public DentalUnitOfWork(string connectionString = null)
        {
            if (connectionString == null)
            {
                _context = new DentalContext(ConnectionStringInfo.Get());
            }
            else
            {
                _context = new DentalContext(connectionString);
            }

            AppointmentDal = new AppointmentDal(_context);
            AppointmentCreateDal = new AppointmentCreateDal(_context);
            DiagnosticDal = new DiagnosticDal(_context);
            DoctorDal = new DoctorDal(_context);
            ExpenseDal = new ExpenseDal(_context);
            ImageDal = new ImageDal(_context);
            PatientDal = new PatientDal(_context);
            PaymentDal = new PaymentDal(_context);
            PremiumDal = new PremiumDal(_context);
            ToothDal = new ToothDal(_context);
            TreatmentConstantDal = new TreatmentConstantDal(_context);
            TreatmentDal = new TreatmentDal(_context);
            UserDal = new UserDal(_context);
            UserRoleDal = new UserRoleDal(_context);
        }
        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public void DetectChange()//Değişiklikleri algılama metodu
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()//Değişiklik yapıldı mı? metodu
        {
            return _context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            return new Repository<TEntity>(_context);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~RestaurantUnitOfWork()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
