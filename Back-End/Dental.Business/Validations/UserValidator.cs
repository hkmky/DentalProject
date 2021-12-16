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
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage(" isim boş geçilmez.").MaximumLength(30)
                .WithMessage("isim 30 karakterden fazla olamaz.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage(" soyad boş geçilmez.").MaximumLength(30)
                .WithMessage("soyad 30 karakterden fazla olamaz.");
            RuleFor(c => c.Email).MaximumLength(30)
                .WithMessage("Email 30 karakterden fazla olamaz.");
            RuleFor(c => c.UserName).NotEmpty().WithMessage(" kullanı ismi boş geçilmez.").MaximumLength(30)
                .WithMessage("kullanıcı ismi 30 karakterden fazla olamaz.");
        }
    }
}
