﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental.Entities.Tables;
using FluentValidation;

namespace Dental.Business.Validations
{ 
    public class ExpenseValidator : AbstractValidator<Expense>
    {
        public ExpenseValidator()
        {
            RuleFor(c => c.Quantity).ScalePrecision(2, 7).WithMessage("Tutar istenilen aralıkta değil");
            
        }
    }
}
