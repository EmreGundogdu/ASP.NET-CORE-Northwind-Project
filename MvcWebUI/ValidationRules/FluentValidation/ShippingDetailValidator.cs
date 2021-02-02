using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            //Rules
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Name is Required");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("LastName is Required");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email is Required");
            RuleFor(s => s.Age).NotEmpty().WithMessage("Age is Required");
            RuleFor(s => s.City).NotEmpty().WithMessage("City is Required");
            RuleFor(s => s.Address).NotEmpty().WithMessage("Address is Required");

            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();

            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);
            //RuleFor(s => s.FirstName).Must(StartWithA);
        }

        //EXAMPLE RULE

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
