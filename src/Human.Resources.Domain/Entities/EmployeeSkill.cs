using Human.Resources.Domain.Validators;

namespace Human.Resources.Domain.Entities
{
    public class EmployeeSkill
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }
}