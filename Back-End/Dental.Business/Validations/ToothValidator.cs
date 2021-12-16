using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{
    public class ToothValidator : AbstractValidator<Tooth>
    {
        public ToothValidator()
        {
            RuleFor(c=>c.Name).NotEmpty().WithMessage("Diş ismi boş geçilemez!").MaximumLength(30)
                .WithMessage("Dis ismi 50 karakterden fazla girilemez.");
        }
    }
}
