using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Business.Manager;
using Dental.Business.Services;
using Dental.DataAccess.UnitOfWork;
using Dental.Entities.Tables;

namespace Dental.Business.Workers
{
    public class DentalWorker : IWorker
    {
        private IUnitOfWork _uow;

        public IAppointmentCreateService AppointmentCreateService { get; set; }
        public IAppointmentService AppointmentService { get; set; }
        public IDiagnosticService DiagnosticService { get; set; }
        public IDoctorService DoctorService { get; set; }
        public IExpenseService ExpenseService { get; set; }
        public IImageService ImageService { get; set; }
        public IPatientService PatientService { get; set; }
        public IPaymentService PaymentService { get; set; }
        public IPremiumService PremiumService { get; set; }
        public IToothService ToothService { get; set; }
        public ITreatmentConstantService TreatmentConstantService { get; set; }
        public ITreatmentService TreatmentService { get; set; }
        public IUserRoleService UserRoleService { get; set; }
        public IUserService UserService { get; set; }


        public DentalWorker(string connectionString = null)
        {
            _uow = new DentalUnitOfWork(connectionString);
            AppointmentCreateService = new AppointmentCreateManager(_uow);
            AppointmentService = new AppointmentManager(_uow);
            DiagnosticService = new DiagnosticManager(_uow);
            DoctorService = new DoctorManager(_uow);
            ExpenseService = new ExpenseManager(_uow);
            ImageService = new ImageManager(_uow);
            PatientService = new PatientManager(_uow);
            PaymentService = new PaymentManager(_uow);
            PremiumService = new PremiumManager(_uow);
            ToothService = new ToothManager(_uow);
            TreatmentConstantService = new TreatmentConstantManager(_uow);
            TreatmentService = new TreatmentManager(_uow);
            UserRoleService = new UserRoleManager(_uow);
            UserService = new UserManager(_uow);

        }


        public bool HasChanges()//Değişiklikleri Algıla
        {
            return _uow.HasChanges();
        }

        public void DetectChanges()
        {
            _uow.DetectChange();
        }

        public bool Commit()
        {
            return _uow.Commit();
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
        // ~RestaurantWorker()
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
