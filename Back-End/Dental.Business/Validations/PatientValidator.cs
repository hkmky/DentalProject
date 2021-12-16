using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{ 
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(c => c.FirstName).MaximumLength(30).NotEmpty().WithMessage("Ad alanı boş geçilemez.").WithMessage("Ad alanı 30 karakterden fazla olamaz.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyad alanı boş geçilemez.").WithMessage("Ad alanı 30 karakterden fazla olamaz.");
            RuleFor(c => c.Email).MaximumLength(30).WithMessage("Email alanı 30 karakterden fazla olamaz.");
            RuleFor(c => c.Telephone).MaximumLength(30).NotEmpty().WithMessage("Telefon alanı boş geçilemez.").WithMessage("Kart No alanı 30 karakterden fazla olamaz.");
        }
    }
}
