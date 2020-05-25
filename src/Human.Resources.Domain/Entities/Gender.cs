using Human.Resources.Domain.Validators;

namespace Human.Resources.Domain.Entities
{
    public class Gender : Entity<Gender>
    {
        public string Name { get; set; }

        public Employee Employee { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new GenderValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}