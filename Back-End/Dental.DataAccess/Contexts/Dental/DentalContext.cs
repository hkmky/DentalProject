using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.DataAccess.Contexts.Base;
using Dental.DataAccess.Mappings;
using Dental.Entities.Tables;
using Dental.Entities.Tables.Base;

namespace Dental.DataAccess.Contexts.Dental
{
    public class DentalContext : BaseContext<DentalContext>
    {
        public DentalContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DentalContext, DentalConfiguration>());
        }

        public DentalContext()
        {
            
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentCreate> AppointmentCreates { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<Tooth> Teeth { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentConstant> TreatmentConstants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                c.HasKey(e => e.Id);



                c.Property(e => e.Id).HasColumnName("Id");


                c.Property(e => e.RecordDate).HasColumnName("RecordDate");
                c.Property(e => e.EditDate).HasColumnName("EditDate");
            });
            //Patient
            modelBuilder.Entity<Appointment>().HasRequired(c => c.Patient).WithMany(c => c.Appointments)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<Diagnostic>().HasRequired(c => c.Patient).WithMany(c => c.Diagnostics)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<Image>().HasRequired(c => c.Patient).WithMany(c => c.Images)
                .HasForeignKey(c => c.PatientId);
            //.Map(c => c.MapKey("BirimId"));
            //Tooth kesinlikle bir tane Patient ihtiyacı var,Patient de Tooth  ihtiyacı var
            modelBuilder.Entity<Tooth>().HasRequired(c => c.Patient).WithMany(c => c.Teeth)
                .HasForeignKey(c => c.PatientId);

            //Appointment

            modelBuilder.Entity<AppointmentCreate>().HasRequired(c => c.Appointment).WithMany(c => c.AppointmentCreates)
                .HasForeignKey(c => c.AppointmentId);

            //Diagnostic
            modelBuilder.Entity<Premium>().HasRequired(c => c.Diagnostic).WithMany(c => c.Premiums)
                .HasForeignKey(c => c.DiagnosticId);

            //Doctor
            modelBuilder.Entity<Diagnostic>().HasRequired(c => c.Doctor).WithMany(c => c.Diagnostics)
                .HasForeignKey(c => c.DoctorId);
            modelBuilder.Entity<Premium>().HasRequired(c => c.Doctor).WithMany(c => c.Premiums)
                .HasForeignKey(c => c.DoctorId);

            //Image
            modelBuilder.Entity<Diagnostic>().HasRequired(c => c.Image).WithMany(c => c.Diagnostics)
                .HasForeignKey(c => c.ImageId);
            // User
            modelBuilder.Entity<UserRole>().HasRequired(c => c.User).WithMany(c => c.UserRoles)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Configurations.Add(new AppointmentCreateMap());
            modelBuilder.Configurations.Add(new AppointmentMap());
            modelBuilder.Configurations.Add(new DiagnosticMap());
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new ExpenseMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new PremiumMap());
            modelBuilder.Configurations.Add(new ToothMap());
            modelBuilder.Configurations.Add(new TreatmentMap());
            modelBuilder.Configurations.Add(new TreatmentConstantMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
        }
    }
}
