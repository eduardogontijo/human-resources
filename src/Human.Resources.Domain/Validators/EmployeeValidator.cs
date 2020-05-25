using FluentValidation;
using Human.Resources.Domain.Entities;

namespace Human.Resources.Domain.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("É necessário informar o Nome.")
                .NotNull().WithMessage("É necessário informar o Nome.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("É necessário informar o Sobrenome.")
                .NotNull().WithMessage("É necessário informar o Sobrenome.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("É necessário informar o Email.")
                .NotNull().WithMessage("É necessário informar o Email.");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("É necessário informar a Data de Nascimento.")
                .NotNull().WithMessage("É necessário informar a Data de Nascimento.");

            RuleFor(c => c.Gender)
                .NotEmpty().WithMessage("É necessário informar o Gênero.")
                .NotNull().WithMessage("É necessário informar o Gênero.");

            RuleFor(c => c.EmployeeSkills)
                .NotEmpty().WithMessage("É necessário pelo menos uma habilidade.")
                .NotNull().WithMessage("É necessário informar pelo menos uma habilidade.");
        }
    }
}
