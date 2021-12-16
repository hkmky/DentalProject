using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{
    public class TreatmentConstantValidator : AbstractValidator<TreatmentConstant>
    {
        public TreatmentConstantValidator()
        {
            RuleFor(c => c.Fee).ScalePrecision(2, 7).WithMessage("Girilen değer istenilen aralıkta değil");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Girilen değer istenilen aralıkta değil").MaximumLength(50).WithMessage("isim alanı 50 karakterden fazla olamaz.");
        }
    }
}
