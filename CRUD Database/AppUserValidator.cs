using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Database
{
    public class AppUserValidator : AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            RuleFor(user => user.Phone).Length(14, 20)
                .WithMessage("Довжина має бути від 14 до 20");
            RuleFor(user => user.Email).EmailAddress()
                .WithMessage("Має бути пошта");

        }
    }
}
