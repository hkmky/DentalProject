using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{
    public class PremiumValidator : AbstractValidator<Premium>
    {
        public PremiumValidator()
        {
            RuleFor(c => c.Percent).ScalePrecision(2, 7).WithMessage("Tutar istenilen aralıkta değil");
        }
    }
}
