using FluentValidation;
using System.Text.RegularExpressions;

namespace FluentValidationTest
{
    public class Form1ViewModelValidator : AbstractValidator<Form1ViewModel>
    {
        public Form1ViewModelValidator()
        {
            RuleFor(n => n.NationalIDCardNumber)
                .Must(BeAValidNid).WithMessage("Invalid card number!");
        }

        protected bool BeAValidNid(string nid)
        {
            var a = ValidationHelper.Cin.IsMatch(nid);

            return a;
        }
    }
}
