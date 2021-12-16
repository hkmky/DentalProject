using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Doctor ismi boş geçilemez!").MaximumLength(30)
                .WithMessage("Doctor ismi 30 karakterden fazla girilemez.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Doctor soyadı boş geçilemez!").MaximumLength(30)
                .WithMessage("Doctor soyadı 30 karakterden fazla girilemez.");
            //RuleFor(c => c.FirstName).NotEmpty().WithMessage("Doctor ismi boş geçilemez!").MaximumLength(30)
            //    .WithMessage("Doctor ismi 30 karakterden fazla girilemez.");

        }
    }
}
