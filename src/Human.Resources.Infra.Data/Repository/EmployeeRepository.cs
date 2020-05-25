using Human.Resources.Domain.Dtos;
using Human.Resources.Domain.Entities;
using Human.Resources.Domain.Interfaces;
using Human.Resources.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Human.Resources.Infra.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HumanResourcesContext context) : base(context)
        {
        }

        //public async Task<IList<EmployeeDto>> GetAll()
        //{
        //    return await _dbSet.Select(e => new EmployeeDto
        //    {
        //        Id = e.Id,
        //        Name = e.Name,
        //        LastName = e.LastName,
        //        Email = e.Email,
        //        BirthDate = e.BirthDate,
        //        Gender = e.Gender,
        //        Skills = e.EmployeeSkills.Select(s => new SkillDto { Id = s.Skill.Id }).ToList()
        //    }).ToListAsync();
        //}

        public override async Task<IList<Employee>> GetAll()
        {
            return await _dbSet.Select(e => new Employee
            {
                Id = e.Id,
                Name = e.Name,
                LastName = e.LastName,
                Email = e.Email,
                BirthDate = e.BirthDate,
                Gender = e.Gender,
                EmployeeSkills = e.EmployeeSkills.Select(s => new EmployeeSkill { Skill = s.Skill}).ToList()
            }).ToListAsync();
        }
    }
}
