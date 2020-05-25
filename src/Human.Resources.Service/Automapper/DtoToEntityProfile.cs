using AutoMapper;
using Human.Resources.Domain.Dtos;
using Human.Resources.Domain.Entities;
using System.Linq;

namespace Human.Resources.Service.Automapper
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<EmployeeDto, Employee>()
                .ForMember(entity => entity.EmployeeSkills, opt => opt.MapFrom(model => model.Skills))
                    .AfterMap((model, entity) =>
                    {
                        foreach (var employeeSkill in entity.EmployeeSkills)
                        {
                            employeeSkill.Employee = entity;
                        }
                    });

            CreateMap<GenderDto, Gender>()
                .ForMember(g => g.Id,
                   opt => opt.MapFrom(g => g.Id));

            CreateMap<SkillDto, Skill>()
                .ForMember(g => g.Id,
                   opt => opt.MapFrom(g => g.Id));

            CreateMap<SkillDto, EmployeeSkill>()
                .ForMember(entity => entity.Skill, opt => opt.MapFrom(model => model));
        }
    }
}
